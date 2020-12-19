namespace ZetaResourceEditor.Runtime.FileAccess
{
    using System;
    using System.IO;
    using ZetaLongPaths;

    public class TemporaryFileCloner :
        IDisposable
    {
        public TemporaryFileCloner(string wordDocumentFilePath)
        {
            FilePath =
                ZlpPathHelper.Combine(
                    Path.GetTempPath(),
                    $@"{Guid.NewGuid()}-{ZlpPathHelper.GetFileNameWithoutExtension(wordDocumentFilePath)}");

            ZlpSafeFileOperations.SafeCopyFile(
                wordDocumentFilePath,
                FilePath);
        }

        public string FilePath { get; }

        #region Implementation of IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            doDispose();
        }

        private void doDispose()
        {
            ZlpSafeFileOperations.SafeDeleteFile(FilePath);
        }

        #endregion
    }
}