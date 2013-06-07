namespace ZetaResourceEditor.Runtime.FileAccess
{
	using System;
	using System.IO;
	using Zeta.EnterpriseLibrary.Common.IO;
	using ZetaLongPaths;

	public class TemporaryFileCloner :
		IDisposable
	{
		private readonly string _tempFilePath;

		public TemporaryFileCloner(string wordDocumentFilePath)
		{
			_tempFilePath =
				ZlpPathHelper.Combine(
					Path.GetTempPath(),
					string.Format(@"{0}-{1}",
						Guid.NewGuid(),
						ZlpPathHelper.GetFileNameWithoutExtension(wordDocumentFilePath)));

			SafeFileOperations.SafeCopyFile(
				wordDocumentFilePath,
				_tempFilePath,
				true);
		}

		public string FilePath
		{
			get
			{
				return _tempFilePath;
			}
		}

		#region Implementation of IDisposable

		public void Dispose()
		{
			GC.SuppressFinalize(this);
			doDispose();
		}

		private void doDispose()
		{
			SafeFileOperations.SafeDeleteFile(_tempFilePath);
		}

		#endregion
	}
}