namespace UpdateChecker;

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
    public string ApiKey { get; set; }
    public DateTime VersionDate { get; set; }
    public string VersionNumber { get; set; }
    public int Culture { get; set; }
}

[Serializable]
public struct UpdatePresentResult2
{
    public bool IsPresent { get; set; }
    public string DownloadWebsiteUrl { get; set; }
}

[Serializable]
public struct UpdateInformationResult2
{
    public string ApiKey { get; set; }

    public bool IsPresent { get; set; }

    public string FileName { get; set; }
    public byte[] FileContent { get; set; }

    public string AlternativeFallbackDownloadUrl { get; set; }
}

[WebService(Namespace = @"http://www.zeta-resource-editor.com/")] // ACHTUNG! HIER _NICHT_ HTTPS machen.
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class UpdateCheckerService :
    ApiKeyProtectedWebServiceBase
{
    [WebMethod]
    public UpdatePresentResult2 IsUpdateAvailable2(
        UpdateCheckInfo2 info)
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

            LogCentral.Current.LogInfo($@"Returning download URL '{url}'.");
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
                $@"Downloading Update for client with version '{info.VersionNumber}', date '{info.VersionDate}'.");

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

            LogCentral.Current.LogInfo($@"Returning download URL '{url}'.");
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
                try
                {
                    result = FileVersionHelper.GetAssemblyVersion(exeFilePath);
                }
                catch (Exception x)
                {
                    LogCentral.Current.Warn(x,
                        $@"Error trying to get assembly version for file '{exeFilePath}', trying file version now.");
                    result = FileVersionHelper.GetFileVersion(exeFilePath);
                }
            }
            else
            {
                result =
                    new Version(
                        ConfigurationManager.AppSettings[@"updateChecker.availableAssemblyVersion"]);
            }

            LogCentral.Current.LogInfo($@"Found version '{result}' on server.");
            return result;
        }
    }

    private static string getExeFilePath()
    {
        var searchFolderPath = ConfigurationManager.AppSettings[@"setupUploadService.baseFolderPath"];

        var filePaths =
            Directory.Exists(searchFolderPath)
                ? new List<string>(Directory.GetFiles(searchFolderPath, @"ZetaResourceEditor.exe*"))
                : new List<string>();

        // Latest first.
        filePaths.Sort(
            (x, y) =>
                -File.GetLastWriteTime(x).CompareTo(
                    File.GetLastWriteTime(y)));

        if (filePaths.Count > 0)
        {
            LogCentral.Current.LogInfo($@"Found file '{filePaths[0]}' when checking for update.");
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
            Directory.Exists(searchFolderPath)
                ? new List<string>(Directory.GetFiles(searchFolderPath, @"ZetaResourceEditor-setup.exe*"))
                : new List<string>();

        // Latest first.
        filePaths.Sort(
            (x, y) =>
                -File.GetLastWriteTime(x).CompareTo(
                    File.GetLastWriteTime(y)));

        if (filePaths.Count > 0)
        {
            LogCentral.Current.LogInfo($@"Found setup file '{filePaths[0]}' when checking for update.");
            return filePaths[0];
        }
        else
        {
            return null;
        }
    }
}