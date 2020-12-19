namespace ZetaResourceEditor.Code
{
    using Properties;
    using System;
    using System.Configuration;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;
    using RuntimeBusinessLogic.UpdateChecker;
    using UI.Helper.Progress;
    using Zeta.VoyagerLibrary.Logging;
    using ZetaLongPaths;

    internal class SetupDownloadController
    {
        private readonly UpdateCheckerService _ws;

        public SetupDownloadController(UpdateCheckerService ws)
        {
            _ws = ws;
        }

        public void DownloadAndRunSetup(
            IWin32Window owner,
            UpdateCheckInfo2 info,
            string downloadWebsiteUrl)
        {
            var error = false;
            string localPath = null;

            using (new BackgroundWorkerLongProgressGui(
                delegate
                {
                    try
                    {
                        var res = _ws.DownloadUpdate2(info);

                        localPath =
                            ZlpPathHelper.Combine(
                                getTempPathIntelligent(),
                                Path.GetFileNameWithoutExtension(res.FileName) +
                                Guid.NewGuid() +
                                Path.GetExtension(res.FileName));

                        File.WriteAllBytes(localPath, res.FileContent);
                    }
                    catch (Exception x)
                    {
                        LogCentral.Current.LogError(
                            @"Error downloading setup of new version.",
                            x);

                        error = true;
                    }
                },
                Resources.SetupDownloadController_DownloadAndRunSetup_Downloading_update__please_wait___,
                BackgroundWorkerLongProgressGui.CancellationMode.NotCancelable,
                owner))
            {
            }

            // --

            if (error)
            {
                // Failed, simply redirect.

                var url = downloadWebsiteUrl;

                LogCentral.Current.LogInfo(
                    $@"About to redirect to update-web page at '{url}' for client with version '{info.VersionNumber}'.");

                var si =
                    new ProcessStartInfo
                    {
                        FileName = url,
                        //Arguments = @" /S",
                        UseShellExecute = true
                    };

                Process.Start(si);
            }
            else
            {
                // Succeeded, run setup, from outside the background thread.

                var si =
                    new ProcessStartInfo
                    {
                        FileName = localPath,
                        Arguments = @"/S",
                        UseShellExecute = true
                    };

                Process.Start(si);

                // TODO: Some day, cleanup the downloaded file.
            }
        }

        private static string getTempPathIntelligent()
        {
            var tempPath = ConfigurationManager.AppSettings[@"temporaryFolderPath"];
            if (string.IsNullOrEmpty(tempPath) || !Directory.Exists(tempPath))
            {
                return Path.GetTempPath();
            }
            else
            {
                return tempPath;
            }
        }
    }
}