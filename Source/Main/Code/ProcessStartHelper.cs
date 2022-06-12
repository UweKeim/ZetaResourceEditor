namespace ZetaResourceEditor.Code;

public static class ProcessStartHelper
{
    public static void OpenUrl(string url)
    {
        var si =
            new ProcessStartInfo
            {
                FileName = url,
                //Arguments = @" /S",
                UseShellExecute = true
            };

        Process.Start(si);
    }

    public static void OpenFolder(string folderPath)
    {
        var info =
            new ProcessStartInfo
            {
                FileName = folderPath,
                UseShellExecute = true
            };

        Process.Start(info);
    }

    public static void OpenFile(string filePath)
    {
        var info =
            new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            };

        Process.Start(info);
    }
}