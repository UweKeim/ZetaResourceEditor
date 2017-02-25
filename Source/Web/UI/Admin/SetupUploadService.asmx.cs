namespace Web.UI.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Web.Services;
    using Zeta.VoyagerLibrary.Logging;
    using ZetaLongPaths;

    [WebService(Namespace = @"http://webservices.zeta-resource-editor.com/setupupload")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class SetupUploadService :
        WebService
    {
        [WebMethod]
        public void TransferSetupFile(
            string apiKey,
            string fileName,
            byte[] fileContent)
        {
            try
            {
                LogCentral.Current.LogInfo(
                    $@"About to receive file with name '{fileContent}' and size {fileContent?.Length ?? 0:#,#} bytes");

                var requiredApiKey =
                    ConfigurationManager.AppSettings[@"setupUploadService.apiKey"];

                if (string.Compare(apiKey, requiredApiKey, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    var baseFolderPath =
                        ConfigurationManager.AppSettings[@"setupUploadService.baseFolderPath"];

                    var destinationFilePath =
                        ZlpPathHelper.Combine(
                            baseFolderPath,
                            fileName);

                    destinationFilePath += @"." + Guid.NewGuid().ToString(@"N");

                    var tempDestinationFilePath = destinationFilePath + @".temporary";

                    // --

                    using (var fs = new FileStream(
                        tempDestinationFilePath,
                        FileMode.Create,
                        FileAccess.Write,
                        FileShare.None))
                    {
                        if (fileContent != null) fs.Write(fileContent, 0, fileContent.Length);
                    }

                    // --

                    File.Move(tempDestinationFilePath, destinationFilePath);

                    // --
                    // Delete any older files, if  currently not in use.

                    var files =
                        new List<FileInfo>(
                            new DirectoryInfo(baseFolderPath).
                                GetFiles(fileName + @"*"));

                    files.RemoveAll(x => x.FullName.ToLowerInvariant().EndsWith(@".temporary"));
                    files.Sort((x, y) => -x.LastWriteTime.CompareTo(y.LastWriteTime));

                    if (files.Count > 1)
                    {
                        for (var index = 1; index < files.Count; ++index)
                        {
                            var file = files[index];

                            try
                            {
                                LogCentral.Current.LogInfo(
                                    $@"About to delete old file '{file.Name}'.");

                                // Try to delete but if failing (usually when in use),
                                // do not fail.
                                file.Delete();
                            }
                            catch (Exception x)
                            {
                                LogCentral.Current.LogError(
                                    $@"Ignoring error while deleting file '{file.Name}'.",
                                    x);
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception(
                        $"Invalid API key '{apiKey}'.");
                }
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(
                    $@"Exception during upload of file '{fileName}' with API key '{apiKey}' and {fileContent?.Length ?? 0:#,#} bytes file size.",
                    x);

                throw;
            }
        }
    }
}