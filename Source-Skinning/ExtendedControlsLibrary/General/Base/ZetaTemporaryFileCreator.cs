namespace ExtendedControlsLibrary.General.Base;

using System;
using System.Diagnostics;
using System.IO;
using ZetaLongPaths;
using FileAttributes = ZetaLongPaths.Native.FileAttributes;

/// <summary>
/// Class for temporary writing a string or binary datato a file and deleting it 
/// again in the destructor/Dispose method.
/// 
/// Use this for ad-hoc writing in-memory strings or binary data to a file and
/// pass the file name to a function that expects a file instead of in-memory data.
/// 
/// Usage of this class:
///     using ( var tfc = new ZetaTemporaryFileCreator( @"Mycontent" ) )
///     {
///         // ...Do some operations to the file...
///         myFunctionThatOperatesOnTheFile( tfc.FilePath );
///     }
/// 
/// I do hope you like it :-) For feedback, see thee remarks comments, below.
/// </summary>
/// 
/// <remarks>
/// Author: Uwe Keim, 2010-09-05, uwe.keim@zeta-software.de, http://twitter.com/UweKeim
/// See other tools we created:
/// - http://www.zeta-resource-editor.com - Edit .NET strings multilingual in parallel.
/// - http://www.zeta-test.com - Test case management tool with Windows and web UI.
/// - http://www.zeta-producer.com - Free website generator CMS for Windows.
/// - http://www.zeta-uploader.com - Sending large files for free by e-mail.
/// </remarks>
internal class ZetaTemporaryFileCreator :
    IDisposable
{
    /// <summary>
    /// Creates a new instance of the file cloner class, automatically
    /// creating a temporary copy of the passed file.
    /// </summary>
    public ZetaTemporaryFileCreator()
    {
        FilePath =
            ZlpPathHelper.Combine(
                Path.GetTempPath(),
                string.Format(@"{0}.txt",
                    Guid.NewGuid()));
    }

    /// <summary>
    /// Creates a new instance of the file cloner class, automatically
    /// creating a temporary copy of the passed file.
    /// </summary>
    /// <param name="content">The content to write.</param>
    public ZetaTemporaryFileCreator(
        string content)
    {
        FilePath =
            ZlpPathHelper.Combine(
                Path.GetTempPath(),
                string.Format(@"{0}.txt",
                    Guid.NewGuid()));

        ZlpIOHelper.WriteAllText(FilePath,content??string.Empty);
        //using (var f = File.CreateText(FilePath))
        //{
        //    f.Write(content ?? string.Empty);
        //}
    }

    /// <summary>
    /// The complete path (drive, directory, file name, extension) to the
    /// temporary file.
    /// </summary>
    public string FilePath { get; private set; }

    public string FileContentString => ZlpIOHelper.FileExists(FilePath) ? ZlpIOHelper.ReadAllText(FilePath) : null;

    #region Implementation of IDisposable

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        doDispose();
    }

    private void doDispose()
    {
        safeDeleteFile(FilePath);
    }

    #endregion

    #region Private helper.

    ~ZetaTemporaryFileCreator()
    {
        doDispose();
    }

    private static bool safeFileExists(
        string filePath)
    {
        return !string.IsNullOrEmpty(filePath) && ZlpIOHelper.FileExists(filePath);
    }

    private static void safeDeleteFile(
        string filePath)
    {
        Trace.TraceInformation(@"About to safe-delete file '{0}'.", filePath);

        if (!string.IsNullOrEmpty(filePath) &&
            safeFileExists(filePath))
        {
            try
            {
                var attributes =
                    ZlpIOHelper.GetFileAttributes(filePath);

                // Remove read-only attributes.
                if ((attributes & FileAttributes.Readonly) != 0)
                {
                    ZlpIOHelper.SetFileAttributes(
                        filePath,
                        attributes & ~FileAttributes.Readonly);
                }

                ZlpSafeFileOperations.SafeDeleteFile(filePath);
            }
            catch (UnauthorizedAccessException x)
            {
                var newFilePath =
                    string.Format(
                        @"{0}.{1:N}.deleted",
                        filePath,
                        Guid.NewGuid());

                Trace.TraceWarning(
                    string.Format(
                        @"Caught UnauthorizedAccessException while deleting file '{0}'. " +
                        @"Renaming now to '{1}'.",
                        filePath,
                        newFilePath),
                    x);

                ZlpIOHelper.MoveFile(
                    filePath,
                    newFilePath);
            }
            catch (Exception x)
            {
                var newFilePath =
                    string.Format(
                        @"{0}.{1:N}.deleted",
                        filePath,
                        Guid.NewGuid());

                Trace.TraceWarning(
                    string.Format(
                        @"Caught IOException while deleting file '{0}'. " +
                        @"Renaming now to '{1}'.",
                        filePath,
                        newFilePath),
                    x);

                ZlpIOHelper.MoveFile(
                    filePath,
                    newFilePath);
            }
        }
        else
        {
            Trace.TraceInformation(@"Not safe-deleting file '{0}', " +
                                   @"because the file does not exist.", filePath);
        }
    }

    #endregion
}