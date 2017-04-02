namespace ZetaResourceEditor.RuntimeUserInterface.Shell
{
	#region Using directives.
	// ----------------------------------------------------------------------
	using System.Diagnostics;
	using Zeta.VoyagerLibrary.Logging;
	using ZetaLongPaths;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Information for passing to the ShellExecute method.
	/// </summary>
	public class ShellExecuteInformation
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Executes this instance.
		/// </summary>
		public void Execute()
		{
			// ReSharper disable InvocationIsSkipped
			LogCentral.Current.LogInfo(
			    $@"About to shell-execute the command '{_fileName}'.");
			// ReSharper restore InvocationIsSkipped

			checkSplitFileName();

			// Do 'normal' ShellExecute.
			var info =
				new ProcessStartInfo
					{
						UseShellExecute = true,
						Verb = Verb,
						FileName = _fileName,
						Arguments = Arguments,
						WorkingDirectory = WorkingDirectory,
						WindowStyle = WindowStyle
					};

			Process.Start(info);
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets or sets the name of the file.
		/// </summary>
		/// <value>The name of the file.</value>
		public string FileName
		{
			get => _fileName;
		    set => _fileName = value;
		}

		/// <summary>
		/// Gets or sets the arguments.
		/// </summary>
		/// <value>The arguments.</value>
		public string Arguments { get; set; }

	    /// <summary>
		/// Gets or sets the working directory.
		/// </summary>
		/// <value>The working directory.</value>
		public string WorkingDirectory { get; set; }

	    /// <summary>
		/// Gets or sets the window style.
		/// </summary>
		/// <value>The window style.</value>
		public ProcessWindowStyle WindowStyle { get; set; }

	    /// <summary>
		/// Gets or sets the verb.
		/// </summary>
		/// <value>The verb.</value>
		public string Verb { get; set; }

	    /// <summary>
		/// Gets or sets a value indicating whether [use HTTP post if applicable].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [use HTTP post if applicable]; otherwise, <c>false</c>.
		/// </value>
		public bool UseHttpPostIfApplicable { get; set; } = true;

	    // ------------------------------------------------------------------
		#endregion

		#region Private methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Splits the file name if it contains an executable AND an argument.
		/// </summary>
		private void checkSplitFileName()
		{
			if (!string.IsNullOrEmpty(_fileName))
			{
				if (_fileName.IndexOf(@"http://") == 0 ||
					_fileName.IndexOf(@"https://") == 0)
				{
					// Already a full path, do nothing.
					return;
				}
				else if (ZlpIOHelper.FileExists(_fileName))
				{
					// Already a full path, do nothing.
					return;
				}
				else if (ZlpIOHelper.DirectoryExists(_fileName))
				{
					// Already a full path, do nothing.
					return;
				}
				else
				{
					// Remember.
					var originalFileName = _fileName;

					if (!string.IsNullOrEmpty(_fileName))
					{
						_fileName = _fileName.Trim();
					}

					if (!string.IsNullOrEmpty(Arguments))
					{
						Arguments = Arguments.Trim();
					}

					// --

					if (string.IsNullOrEmpty(Arguments) &&
						!string.IsNullOrEmpty(_fileName) && _fileName.Length > 2)
					{
						if (_fileName.StartsWith(@""""))
						{
							int pos = _fileName.IndexOf(@"""", 1);

							if (pos > 0 && _fileName.Length > pos + 1)
							{
								Arguments = _fileName.Substring(pos + 1).Trim();
								_fileName = _fileName.Substring(0, pos + 1).Trim();
							}
						}
						else
						{
							int pos = _fileName.IndexOf(@" ");
							if (pos > 0 && _fileName.Length > pos + 1)
							{
								Arguments = _fileName.Substring(pos + 1).Trim();
								_fileName = _fileName.Substring(0, pos + 1).Trim();
							}
						}
					}

					// --
					// Possibly revert back.

					if (!string.IsNullOrEmpty(_fileName))
					{
						string s = _fileName.Trim('"');
						if (!ZlpIOHelper.FileExists(s) && !ZlpIOHelper.DirectoryExists(s))
						{
							_fileName = originalFileName;
						}
					}
				}
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		/// <summary>
		/// The maximum number of characters allowed without POSTing.
		/// </summary>
		//private static readonly int _httpGetLengthLimit = 1000;

		private string _fileName;

	    // ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}