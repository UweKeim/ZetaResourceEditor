namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Globalization;
	using ExportImportExcel;
	using Language;
	using Properties;
	using Runtime.FileAccess;
	using WebServices;
	using Zeta.VoyagerLibrary.Common.IO;
	using Zeta.VoyagerLibrary.Common.IO.Compression;
	using ZetaLongPaths;
	using ZetaUploader;

	public class SendProjectController
	{
		public static string VendorReceiverGuiName => Resources.SendProjectController_VendorReceiverGuiName_Zeta_Resource_Editor_support;

	    public SendProjectResult SendProject(
			BackgroundWorker bw,
			SendProjectInformation information)
		{
			var result = new SendProjectResult();

			var filePathsToSend = new List<string>();

			// --

			information.SendFilesEMailReceivers = translate(information.SendFilesEMailReceivers);

			if (information.SendLocalSettings)
			{
				filePathsToSend.Add(information.SettingsFilePath);
			}

			if (information.SendProjectFile)
			{
				filePathsToSend.Add(information.Project.ProjectConfigurationFilePath.FullName);
			}

			if (information.SendResourceFiles)
			{
				if (information.SendProjectFile)
				{
					// TODO: Later, we could also copy the RESX files to a
					// TODO: temporary location and adjust the references
					// TODO: to them inside the project file to have a
					// TODO: ready-to-open project being generated.
				}

				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var fileGroup in information.Project.FileGroups)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					if (bw.CancellationPending)
					{
						throw new OperationCanceledException();
					}

					// ReSharper disable LoopCanBeConvertedToQuery
					foreach (var filePath in fileGroup.FilePaths)
					// ReSharper restore LoopCanBeConvertedToQuery
					{
						filePathsToSend.Add(filePath);
					}
				}
			}

			// --

			result.DownloadUrl = doSendFilesWithZetaUploader(bw, information, filePathsToSend.ToArray());

			return result;
		}

		private static string translate(string sendFilesEMailReceivers)
		{
			if(string.IsNullOrEmpty(sendFilesEMailReceivers))
			{
				return sendFilesEMailReceivers;
			}
			else
			{
				sendFilesEMailReceivers = sendFilesEMailReceivers.Trim();
				if (string.Compare(sendFilesEMailReceivers, 
					VendorReceiverGuiName, StringComparison.OrdinalIgnoreCase)==0)
				{
					// The vendor GUI name has to be translated to an actual email address.
					return @"uwe.keim@gmail.com, errors.zeta@googlemail.com";
				}
				else
				{
					return sendFilesEMailReceivers;
				}
			}
		}

		private static string doSendFilesWithZetaUploader(
			BackgroundWorker bw,
			SendProjectInformation information,
			string[] filePathsToSend)
		{
			if (filePathsToSend.Length > 0)
			{
				bw.ReportProgress(
					0,
					new ExcelProgressInformation
					{
						TemporaryProgressMessage =
							string.Format(
								Resources.ExcelExportController_doSendFilesWithZetaUploader_Sending__0__files_through_Zeta_Uploader___,
								filePathsToSend.Length)
					});

				var sendInfo =
					new ZetaUploaderCommunicationClientTransferInformation2
					{
						EMailReceiverAddresses =
							splitEMailAddresses(
								information.SendFilesEMailReceivers),
						EMailSubject =
							replaceEMailPlaceholders(
								information.SendFilesEMailSubject, information),
						AdditionalRemarks =
							replaceEMailPlaceholders(
								information.SendFilesEMailBody, information),
						Language =
							CultureHelper.GetSupportedUICultureFromThreeLetterWindowsLanguageName(
								CultureInfo.CurrentUICulture.ThreeLetterWindowsLanguageName).TwoLetterISOLanguageName,
						UserStates = new[] { new ZulPair { Name = @"allow-browse", Value = bool.TrueString } },
					};

				// --

				if (filePathsToSend.Length == 1)
				{
					sendInfo.FileName = ZlpPathHelper.GetFileNameFromFilePath(filePathsToSend[0]);
					sendInfo.FileContent = ZlpIOHelper.ReadAllBytes(filePathsToSend[0]);
				}
				else
				{
					sendInfo.FileName = replaceEMailPlaceholders(@"ZRE-Sent-Project-{SafeProjectName}.zip", information);

					var compressInfos = new CompressHeterogeneousInfos();

					compressInfos.AddFiles(filePathsToSend);

					sendInfo.FileContent =
						CompressionHelper.CompressHeterogeneous(
							compressInfos);
				}

				if (bw.CancellationPending)
				{
					throw new OperationCanceledException();
				}

				var ws = WebServiceManager.Current.ZetaUploaderWS;
				var result = ws.SendFile2(sendInfo);

				return result.DownloadUrl;
			}
			else
			{
				throw new Exception(Resources.SendProjectController_doSendFilesWithZetaUploader_No_files_to_send_);
			}
		}

		private static string replaceEMailPlaceholders(
			string text,
			SendProjectInformation information)
		{
			if (string.IsNullOrEmpty(text))
			{
				return text;
			}
			else
			{
				text = text.Replace(@"{ProjectName}", information.Project.Name);
				text = text.Replace(@"{SafeProjectName}", ZrePathHelper.MakeValidObjectID(information.Project.Name));

				return text;
			}
		}

		private static string[] splitEMailAddresses(string sendFilesEMailReceivers)
		{
			var result = new List<string>();

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var email in sendFilesEMailReceivers.Split(','))
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				var e = email.Trim();

				if (e.Length > 0)
				{
					result.Add(e);
				}
			}

			return result.ToArray();
		}
	}
}