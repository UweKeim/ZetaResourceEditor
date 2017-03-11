namespace UpdateChecker
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Web.Services;
    using Code;
    using Zeta.VoyagerLibrary.Common.IO;
    using Zeta.VoyagerLibrary.Logging;

    [Serializable]
    public struct UpdateCheckInfo2
    {
        public string ApiKey;
        public DateTime VersionDate;
        public string VersionNumber;
        public int Culture;
    }

    [Serializable]
    public struct UpdatePresentResult2
    {
        public bool IsPresent;
        public string DownloadWebsiteUrl;
    }

    [Serializable]
    public struct UpdateInformationResult2
    {
        public string ApiKey;

        public bool IsPresent;

        public string FileName;
        public byte[] FileContent;

        public string AlternativeFallbackDownloadUrl;
    }

    [WebService(Namespace = @"https://www.zeta-resource-editor.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class UpdateCheckerService :
        ApiKeyProtectedWebServiceBase
    {
        [WebMethod]
        public UpdatePresentResult2 IsUpdateAvailable2(
            UpdateCheckInfo2 info )
        {
            try
            {
                CheckThrowApiKey(info.ApiKey);

                var v1 = new Version(info.VersionNumber);
                var v2 = availableVersion;

                var url = v1 >= v2 ? string.Empty : ConfigurationManager.AppSettings[@"updateChecker.downloadUrl"];
                var web = v1 >= v2 ? string.Empty : ConfigurationManager.AppSettings[@"updateChecker.websiteUrl"];

                var result =
                    new UpdatePresentResult2
                    {
                        IsPresent = v1 < v2, 
                        DownloadWebsiteUrl = web
                    };

                LogCentral.Current.LogInfo(string.Format(@"Returning download URL '{0}'.", url));
                return result;
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(@"Error checking whether an update is available.", x);
                throw;
            }
        }

        [WebMethod]
        public UpdateInformationResult2 DownloadUpdate2(
            UpdateCheckInfo2 info)
        {
            try
            {
                CheckThrowApiKey(info.ApiKey);

                LogCentral.Current.LogInfo(
                    string.Format(
                        @"Downloading Update for client with version '{0}', date '{1}'.",
                        info.VersionNumber,
                        info.VersionDate));

                var avail = IsUpdateAvailable2(info);

                var result =
                    new UpdateInformationResult2
                    {
                        IsPresent = avail.IsPresent,
                        AlternativeFallbackDownloadUrl = avail.DownloadWebsiteUrl,
                        FileName = @"ZetaResourceEditor-setup.exe",
                        FileContent = File.ReadAllBytes(getSetupExeFilePath())
                    };

                return result;
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(@"Error downloading update .", x);
                throw;
            }
        }

        [WebMethod]
        public string IsUpdateAvailable(
            string assemblyVersion)
        {
            try
            {
                var v1 = new Version(assemblyVersion);
                var v2 = availableVersion;

                var url = v1 >= v2 ? string.Empty : ConfigurationManager.AppSettings[@"updateChecker.downloadUrl"];

                LogCentral.Current.LogInfo(string.Format(@"Returning download URL '{0}'.", url));
                return url;
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(@"Error checking whether an update is available.", x);
                throw;
            }
        }

        private static Version availableVersion
        {
            get
            {
                var exeFilePath = getExeFilePath();
                Version result;

                if (!string.IsNullOrEmpty(exeFilePath) && File.Exists(exeFilePath))
                {
                    result = FileVersionHelper.GetAssemblyVersion(exeFilePath);
                }
                else
                {
                    result =
                        new Version(
                            ConfigurationManager.AppSettings[@"updateChecker.availableAssemblyVersion"]);
                }

                LogCentral.Current.LogInfo(string.Format(@"Found version '{0}' on server.", result));
                return result;
            }
        }

        private static string getExeFilePath()
        {
            var searchFolderPath = ConfigurationManager.AppSettings[@"setupUploadService.baseFolderPath"];

            var filePaths =
                new List<string>(
                    Directory.GetFiles(searchFolderPath, @"ZetaResourceEditor.exe*"));

            // Latest first.
            filePaths.Sort(
                (x, y) =>
                    -File.GetLastWriteTime(x).CompareTo(
                        File.GetLastWriteTime(y)));

            if (filePaths.Count > 0)
            {
                LogCentral.Current.LogInfo(string.Format(@"Found file '{0}' when checking for update.", filePaths[0]));
                return filePaths[0];
            }
            else
            {
                return null;
            }
        }

        private static string getSetupExeFilePath()
        {
            var searchFolderPath = ConfigurationManager.AppSettings[@"setupUploadService.baseFolderPath"];

            var filePaths =
                new List<string>(
                    Directory.GetFiles(searchFolderPath, @"ZetaResourceEditor-setup.exe*"));

            // Latest first.
            filePaths.Sort(
                (x, y) =>
                    -File.GetLastWriteTime(x).CompareTo(
                        File.GetLastWriteTime(y)));

            if (filePaths.Count > 0)
            {
                LogCentral.Current.LogInfo(string.Format(@"Found setup file '{0}' when checking for update.", filePaths[0]));
                return filePaths[0];
            }
            else
            {
                return null;
            }
        }
    }
}