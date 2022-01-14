namespace ZetaResourceEditor.RuntimeBusinessLogic.Snapshots;

using Projects;
using Runtime;
using System.Data.SQLite;
using ZetaLongPaths;

public abstract class SnapshotControllerBase
{
    protected Project Project { get; }

    protected SnapshotControllerBase(
        Project project)
    {
        Project = project;
    }

    public void Initialize()
    {
        checkTablesCreated();
    }

    public void DeleteSettingValue(
        string key)
    {
        if (!StringExtensionMethods.IsNullOrWhiteSpace(key))
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            var cmd =
                new SQLiteCommand(connection)
                {
                    CommandText = @"DELETE FROM ZreSettings WHERE Value1=@Value1"
                };
            cmd.Parameters.Add(new SQLiteParameter(@"@Value1") { Value = key });

            cmd.ExecuteNonQuery();
        }
    }

    public void PutSettingValue(
        string key,
        string value)
    {
        if (!StringExtensionMethods.IsNullOrWhiteSpace(key))
        {
            DeleteSettingValue(key);

            if (!string.IsNullOrEmpty(value))
            {
                using var connection = new SQLiteConnection(connectionString);
                connection.Open();
                var cmd =
                    new SQLiteCommand(connection)
                    {
                        CommandText = @"INSERT INTO ZreSettings (Value1, Value2) VALUES (@Value1, @Value2)"
                    };
                cmd.Parameters.Add(new SQLiteParameter(@"@Value1") { Value = key });
                cmd.Parameters.Add(new SQLiteParameter(@"@Value2") { Value = value });

                cmd.ExecuteNonQuery();
            }
        }
    }

    public string GetSettingValue(
        string key)
    {
        if (StringExtensionMethods.IsNullOrWhiteSpace(key))
        {
            return null;
        }
        else
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            var cmd =
                new SQLiteCommand(connection)
                {
                    CommandText = @"SELECT Value2 FROM ZreSettings WHERE Value1=@Value1"
                };
            cmd.Parameters.Add(new SQLiteParameter(@"@Value1") { Value = key });

            return cmd.ExecuteScalar() as string;
        }
    }

    private void checkTablesCreated()
    {
        if (!ZlpIOHelper.FileExists(databaseFilePath))
        {
            // http://sqlite.phxsoftware.com/forums/t/77.aspx.
            SQLiteConnection.CreateFile(databaseFilePath);
        }

        if (!doesTableExist(@"ZreSettings"))
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            new SQLiteCommand(connection)
            {
                CommandText =
                    @"CREATE TABLE ZreSettings
                    (
                        ID INTEGER PRIMARY KEY ASC,
                        Value1,
                        Value2,
                        Value3,
                        Value4
                    )"
            }.ExecuteNonQuery();
        }
    }

    private string connectionString => $@"Data Source={databaseFilePath};Pooling=true;FailIfMissing=false";

    protected string databaseFilePath => ZlpPathHelper.ChangeExtension(Project.ProjectConfigurationFilePath.FullName, @".zredb");

    private bool doesTableExist(
        string tableName)
    {
        using var connection = new SQLiteConnection(connectionString);
        connection.Open();
        return doesTableExist(connection, tableName);
    }

    private static bool doesTableExist(
        SQLiteConnection connection,
        string tableName)
    {
        // http://sqlite.phxsoftware.com/forums/t/776.aspx.
        var cmd =
            new SQLiteCommand(connection)
            {
                CommandText = $@"SELECT name FROM sqlite_master WHERE name='{tableName}'"
            };
        var rdr = cmd.ExecuteReader();
        return rdr.HasRows;
    }

}