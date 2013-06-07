<%@ WebService Language="C#" Class="SetupUploadService" %>

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web.Services;
using Zeta.EnterpriseLibrary.Common.IO;
using Zeta.EnterpriseLibrary.Logging;

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
				string.Format(
					@"About to receive file with name '{0}' and size {1:#,#} bytes",
					fileContent,
					fileContent == null ? 0 : fileContent.Length));

			var requiredApiKey =
				ConfigurationManager.AppSettings[@"setupUploadService.apiKey"];

			if (string.Compare(apiKey, requiredApiKey, true) == 0)
			{
				var baseFolderPath =
					ConfigurationManager.AppSettings[@"setupUploadService.baseFolderPath"];

				var destinationFilePath =
					PathHelper.Combine(
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
					fs.Write(fileContent, 0, fileContent == null ? 0 : fileContent.Length);
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
								string.Format(
									@"About to delete old file '{0}'.",
									file.Name));
							
							// Try to delete but if failing (usually when in use),
							// do not fail.
							file.Delete();
						}
						catch (Exception x)
						{
							LogCentral.Current.LogError(
								string.Format(
									@"Ignoring error while deleting file '{0}'.",
									file.Name),
								x);
						}
					}
				}
			}
			else
			{
				throw new Exception(
					string.Format(
						"Invalid API key '{0}'.",
						apiKey));
			}
		}
		catch (Exception x)
		{
			LogCentral.Current.LogError(
				string.Format(
					@"Exception during upload of file '{0}' with API key '{1}' and {2:#,#} bytes file size.",
					fileName,
					apiKey,
					fileContent == null ? 0 : fileContent.Length),
				x);

			throw;
		}
	}
}