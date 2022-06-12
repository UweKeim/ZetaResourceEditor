namespace ZetaResourceEditor.RuntimeUserInterface.Shell;

using System.IO;

/// <summary>
/// Information for passing to the ShellExecute method.
/// </summary>
public sealed class ShellExecuteInformation
{
    public void Execute()
    {
        LogCentral.Current.LogInfo(
            $@"About to shell-execute the command '{FileName}'.");

        checkSplitFileName();

        // Do 'normal' ShellExecute.
        var info =
            new ProcessStartInfo
            {
                UseShellExecute = true,
                Verb = Verb,
                FileName = FileName,
                Arguments = Arguments,
                WorkingDirectory = WorkingDirectory,
                WindowStyle = WindowStyle
            };

        Process.Start(info);
    }

    public string FileName { get; set; }

    public string Arguments { get; set; }

    public string WorkingDirectory { get; set; }

    public ProcessWindowStyle WindowStyle { get; set; }

    public string Verb { get; set; }

    private void checkSplitFileName()
    {
        if (!string.IsNullOrEmpty(FileName))
        {
            if (FileName.IndexOf(@"http://", StringComparison.Ordinal) == 0 ||
                FileName.IndexOf(@"https://", StringComparison.Ordinal) == 0)
            {
                // Already a full path, do nothing.
            }
            else if (File.Exists(FileName))
            {
                // Already a full path, do nothing.
            }
            else if (Directory.Exists(FileName))
            {
                // Already a full path, do nothing.
            }
            else
            {
                // Remember.
                var originalFileName = FileName;

                if (!string.IsNullOrEmpty(FileName))
                {
                    FileName = FileName.Trim();
                }

                if (!string.IsNullOrEmpty(Arguments))
                {
                    Arguments = Arguments.Trim();
                }

                // --

                if (string.IsNullOrEmpty(Arguments) &&
                    !string.IsNullOrEmpty(FileName) && FileName.Length > 2)
                {
                    if (FileName.StartsWith(@""""))
                    {
                        var pos = FileName.IndexOf(@"""", 1, StringComparison.Ordinal);

                        if (pos > 0 && FileName.Length > pos + 1)
                        {
                            Arguments = FileName.Substring(pos + 1).Trim();
                            FileName = FileName.Substring(0, pos + 1).Trim();
                        }
                    }
                    else
                    {
                        var pos = FileName.IndexOf(@" ", StringComparison.Ordinal);
                        if (pos > 0 && FileName.Length > pos + 1)
                        {
                            Arguments = FileName.Substring(pos + 1).Trim();
                            FileName = FileName.Substring(0, pos + 1).Trim();
                        }
                    }
                }

                // --
                // Possibly revert back.

                if (!string.IsNullOrEmpty(FileName))
                {
                    var s = FileName.Trim('"');
                    if (!File.Exists(s) && !Directory.Exists(s))
                    {
                        FileName = originalFileName;
                    }
                }
            }
        }
    }
}