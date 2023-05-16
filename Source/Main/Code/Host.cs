namespace ZetaResourceEditor.Code;

using ExtendedControlsLibrary.Skinning;
using Properties;
using RuntimeBusinessLogic.Projects;
using UI.Helper.ErrorHandling;
using UI.Main;
using Zeta.VoyagerLibrary.Core.Tools.Miscellaneous;
using Zeta.VoyagerLibrary.Core.Tools.Storage;

internal sealed class Host
{
	private static DirectoryInfo? _cacheForCurrentUserStorageBaseFolderPath;

	[STAThread]
	private static void Main()
	{
		try
		{
			LogCentral.Current.ConfigureLogging();

			// --
			// Register extension.

			try
			{
				var info =
					new FileExtensionRegistration.RegistrationInformation
					{
						ApplicationFilePath = typeof(Host).Assembly.Location,
						Extension = Project.ProjectFileExtension,
						ClassName = @"ZetaResourceEditorDocument",
						Description = Resources.SR_Host_Main_ZetaResourceEditorProjectFile
					};

				FileExtensionRegistration.Register(info);
			}
			catch (Exception x)
			{
				// May fail if no permissions, silently eat.
				LogCentral.Current.LogError(x);
			}

			// --

			var persistentStorage =
				new PersistentXmlFilePairStorage
				{
					FilePath =
						ZspPathHelper.Combine(
							CurrentUserStorageBaseFolderPath.FullName,
							@"zeta-resource-editor-settings.xml") ?? string.Empty
				};
			persistentStorage.Error += storageError;

			PersistanceHelper.Storage = persistentStorage;

			// --

			// http://community.devexpress.com/forums/t/80133.aspx

			SkinHelper.InitializeAll();

			// https://github.com/UweKeim/ZetaResourceEditor/issues/55
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			// --

			AppDomain.CurrentDomain.UnhandledException += currentDomainUnhandledException;
			Application.ThreadException += applicationThreadException;

			// --

			Application.Run(new MainForm());
		}
		catch (Exception x)
		{
			doHandleException(x);
		}
	}

	private static void currentDomainUnhandledException(
		object sender,
		UnhandledExceptionEventArgs e)
	{
		doHandleException(e.ExceptionObject as Exception);
	}

	private static void applicationThreadException(
		object sender,
		ThreadExceptionEventArgs e)
	{
		doHandleException(e.Exception);
	}

	public static void NotifyAboutException(
		Exception e)
	{
		doHandleException(e);
	}

	private static void doHandleException(
		Exception? e)
	{
		LogCentral.Current.Warn(e);

		bool handleException;

		switch (e)
		{
			case MessageBoxException exception:
				{
					var mbx = exception;

					XtraMessageBox.Show(
						mbx.Parent,
						mbx.Message,
						@"Zeta Resource Editor",
						mbx.Buttons,
						mbx.Icon);

					handleException = false;
					break;
				}
			case PersistentPairStorageException:
				{
					// 2009-06-22, Uwe Keim:
					// http://zeta-producer.de/Pages/AdvancedForumIndex.aspx?DataID=9514
					LogCentral.Current.LogWarn(
						@"PersistentPairStorageException occurred.", e);

					switch (e.InnerException)
					{
						case null:
							handleException = true;
							break;
						case UnauthorizedAccessException:
						case IOException:
							handleException = false;
							break;
						default:
							handleException = true;
							break;
					}

					break;
				}
			default:
				handleException = true;
				break;
		}

		// --

		if (handleException)
		{
			LogCentral.Current.LogError(@"Exception occurred.", e);

			// Do not allow recursive exceptions, since the
			// Application.ThreadException would eat them anyway.
			try
			{
				using var form = new ErrorForm();
				form.Initialize(e);
				var result = form.ShowDialog(Form.ActiveForm);

				if (result == DialogResult.Abort)
				{
					Process.GetCurrentProcess().Kill(true);
					Application.Exit();
				}
			}
			catch (Exception x)
			{
				LogCentral.Current.LogError(
					@"Exception occurred during exception handling.",
					x);

				XtraMessageBox.Show(
					Form.ActiveForm,
					string.Format(@"{0}{1}{1}{2}",
						x.Message,
						Environment.NewLine,
						e?.Message ?? "Unknown error"),
					@"Zeta Resource Editor",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}

	private static void storageError(
		object? sender,
		PersistentPairStorageErrorEventArgs args)
	{
		if (args.RetryCount <= 2)
		{
			Application.DoEvents();
			Thread.Sleep(0);

			args.Result = CheckHandleExceptionResult.Retry;
		}
		else
		{
			args.Result = CheckHandleExceptionResult.Ignore;
		}
	}

	public static DirectoryInfo CurrentUserStorageBaseFolderPath
	{
		get
		{
			if (_cacheForCurrentUserStorageBaseFolderPath == null)
			{
				const string folderName = @"Zeta Resource Editor";

				var result = new DirectoryInfo(
					ZspPathHelper.Combine(
						Environment.GetFolderPath(
							Environment.SpecialFolder.LocalApplicationData),
						folderName) ?? string.Empty);

				_cacheForCurrentUserStorageBaseFolderPath = result.CheckCreate();
			}

			return _cacheForCurrentUserStorageBaseFolderPath;
		}
	}
}