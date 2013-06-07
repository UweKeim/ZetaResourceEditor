namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.Sys
{
	using System.Configuration;
	using System.IO;
	using System.Net.Mail;
	using System.Text;
	using Zeta.EnterpriseLibrary.Common.IO;
	using Zeta.EnterpriseLibrary.Logging;

	public static class MailHelper
	{
		public static void WriteMailToFile(
			MailMessage message,
			string fileName)
		{
			WriteMailToFile(
				message,
				ConfigurationManager.AppSettings[@"mailWriteFilePath"],
				fileName);
		}

		public static void WriteMailToFile(
			MailMessage message,
			string folderPath,
			string fileName)
		{
			if (!string.IsNullOrEmpty(folderPath))
			{
				folderPath = LogCentral.ExpandFilePathMacros(folderPath);
				fileName = LogCentral.ExpandFilePathMacros(fileName);

				if (!Directory.Exists(folderPath))
				{
					Directory.CreateDirectory(folderPath);
				}

				var filePath = PathHelper.Combine(folderPath, fileName);
				if (Directory.Exists(filePath))
				{
					File.Delete(filePath);
				}

				// --

				using (var sw =
					new StreamWriter(filePath, false, message.BodyEncoding ?? Encoding.UTF8))
				{
					sw.Write(message.Body);
				}
			}
		}
	}
}