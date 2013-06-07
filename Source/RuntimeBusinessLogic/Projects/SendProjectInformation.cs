namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects
{
	public class SendProjectInformation
	{
		public Project Project { get; set; }
		public string SettingsFilePath { get; set; }

		public bool SendProjectFile { get; set; }
		public bool SendResourceFiles { get; set; }
		public bool SendLocalSettings { get; set; }

		public string SendFilesEMailReceivers { get; set; }
		public string SendFilesEMailSubject { get; set; }
		public string SendFilesEMailBody { get; set; }
	}
}