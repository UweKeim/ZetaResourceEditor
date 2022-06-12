namespace ZetaResourceEditor.Runtime.FileAccess;

using System.IO;

public class TemporaryFileCloner :
    IDisposable
{
    public TemporaryFileCloner(string wordDocumentFilePath)
    {
        FilePath =
            ZspPathHelper.Combine(
                Path.GetTempPath(),
                $@"{Guid.NewGuid()}-{ZspPathHelper.GetFileNameWithoutExtension(wordDocumentFilePath)}");

        ZspSafeFileOperations.SafeCopyFile(
            wordDocumentFilePath,
            FilePath);
    }

    public string FilePath { get; }

    #region Implementation of IDisposable

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        doDispose();
    }

    private void doDispose()
    {
        ZspSafeFileOperations.SafeDeleteFile(FilePath);
    }

    #endregion
}