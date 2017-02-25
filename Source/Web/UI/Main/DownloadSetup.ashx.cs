namespace Web.UI.Main
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Web;
    using Zeta.VoyagerLibrary.Common.IO;
    using Zeta.VoyagerLibrary.Logging;

    public class DownloadSetup :
        IHttpHandler
    {
        public void ProcessRequest(
            HttpContext context)
        {
            try
            {
                var fileName = context.Request[@"f"];

                if (string.IsNullOrEmpty(fileName))
                {
                    throw new Exception(
                        "No file name specified.");
                }
                else
                {
                    var baseFolderPath =
                        ConfigurationManager.AppSettings[
                            @"setupUploadService.baseFolderPath"];

                    var files =
                        new List<FileInfo>(
                            new DirectoryInfo(baseFolderPath).
                                GetFiles(fileName + @"*"));

                    files.RemoveAll(x => x.FullName.ToLowerInvariant().EndsWith(@".temporary"));
                    files.Sort((x, y) => -x.LastWriteTime.CompareTo(y.LastWriteTime));

                    if (files.Count >= 1)
                    {
                        var file = files[0];

                        context.Response.ClearContent();

                        LogCentral.Current.LogInfo(
                            $@"About to send file '{file.FullName}' as file '{fileName}' to browser.");

                        // http://support.microsoft.com/kb/812406/en-us/
                        streamFileToBrowser(context.Response, file, fileName);
                    }
                    else
                    {
                        throw new Exception(
                            $"File '{fileName}' was not found.");
                    }
                }
            }
            catch (HttpException x)
            {
                if (x.ErrorCode == 0x800703E3 ||
                    x.ErrorCode == 0x80070016 ||
                    x.Message.IndexOf(@"0x800703E3", StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                    x.Message.IndexOf(@"0x80070016", StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                    x.Message.IndexOf(@"The remote host closed the connection", StringComparison.InvariantCultureIgnoreCase) >=
                    0)
                {
                    // "The remote host closed the connection. The error code is 0x800703E3."

                    // Ignore.
                }
                else
                {
                    LogCentral.Current.LogError(
                        $@"HttpException during downloading file '{context.Request.QueryString}'.",
                        x);

                    throw;
                }
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(
                    $@"Exception during downloading file '{context.Request.QueryString}'.",
                    x);

                throw;
            }
        }

        // http://support.microsoft.com/kb/812406/en-us/
        private static void streamFileToBrowser(
            HttpResponse response,
            FileInfo file,
            string fileName)
        {
            Stream iStream = null;

            try
            {
                // Open the file.
                iStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);

                // Total bytes to read:
                var dataToRead = iStream.Length;

                response.Cache.SetExpires(DateTime.Now - TimeSpan.FromDays(1000));

                response.ContentType = MimeHelper.MapFileExtensionToMimeType(Path.GetExtension(fileName)); //@"application/octet-stream";
                response.AddHeader(@"Content-Disposition", @"attachment; filename=" + fileName);
                response.AddHeader(@"Content-Length", $@"{file.Length}");

                // Read the bytes.
                while (dataToRead > 0)
                {
                    // Verify that the client is connected.
                    if (response.IsClientConnected)
                    {
                        // Read the data in buffer.
                        var buffer = new byte[10000];
                        var length = iStream.Read(buffer, 0, 10000);

                        // Write the data to the current output stream.
                        response.OutputStream.Write(buffer, 0, length);

                        // Flush the data to the HTML output.
                        response.Flush();

                        dataToRead = dataToRead - length;
                    }
                    else
                    {
                        //prevent infinite loop if user disconnects
                        dataToRead = -1;
                    }
                }
            }
            finally
            {
                if (iStream != null)
                {
                    iStream.Close();
                    iStream.Dispose();
                }
                response.Close();
            }
        }

        public bool IsReusable => false;
    }
}