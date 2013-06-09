namespace ZetaResourceEditor.Code
{
	using System;
	using System.Globalization;
	using System.IO;
	using System.Threading;
	using System.Windows.Forms;
	using DevExpress.XtraEditors;
	using RuntimeBusinessLogic.Projects;
	using UI.Helper.ErrorHandling;
	using Properties;
	using UI.Main;
	using Zeta.EnterpriseLibrary.Logging;
	using Zeta.EnterpriseLibrary.Tools.Miscellaneous;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using ZetaLongPaths;

	internal sealed class Host
	{
		private static ZlpDirectoryInfo _cacheForCurrentUserStorageBaseFolderPath;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			try
			{
				//Zeta.EnterpriseLibrary.Common.Configuration.
				//    LibraryConfiguration.Current.Initialize();
				//Zeta.EnterpriseLibrary.Windows.Configuration.
				//    LibraryConfiguration.Current.Initialize();

				LogCentral.Current.ConfigureLogging();

				// --
				// Register extension.

				try
				{
					var info =
						new FileExtensionRegistration.RegistrationInformation
						{
							ApplicationFilePath = typeof( Host ).Assembly.Location,
							Extension = Project.ProjectFileExtension,
							ClassName = @"ZetaResourceEditorDocument",
							Description = Resources.SR_Host_Main_ZetaResourceEditorProjectFile
						};

					FileExtensionRegistration.Register( info );
				}
				catch ( Exception x )
				{
					// May fail if no permissions, silently eat.
					LogCentral.Current.LogError( x );
				}

				// --

				var persistentStorage =
					new PersistentXmlFilePairStorage
						{
							FilePath =
								ZlpPathHelper.Combine(
									CurrentUserStorageBaseFolderPath.FullName,
									@"zeta-resource-editor-settings.xml")
						};
				persistentStorage.Error += storageError;

				PersistanceHelper.Storage = persistentStorage;

				// --

				// http://community.devexpress.com/forums/t/80133.aspx

				// http://www.devexpress.com/Support/Center/p/B155647.aspx
				//DevExpress.UserSkins.OfficeSkins.Register();
				//DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = @"Office 2010 Silver";

				DevExpress.Skins.SkinManager.EnableFormSkins();

				// --

				// Manually turn off.
				//Zeta.EnterpriseLibrary.Windows.Configuration.
				//    LibraryConfiguration.Current.IsDesignMode = false;

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault( false );

				AppDomain.CurrentDomain.UnhandledException +=
					currentDomainUnhandledException;
				Application.ThreadException +=
					applicationThreadException;

				test();

				initializeLanguage();

				Application.Run( new MainForm() );
			}
			catch ( Exception x )
			{
				doHandleException( x );
			}
		}

		public static void ApplyLanguageSettingsToCurrentThread()
		{
			foreach (var e in Environment.GetCommandLineArgs())
			{
				if (e.StartsWith(@"-language") || e.StartsWith(@"/language"))
				{
					var f = e.Replace(@"language", string.Empty);
					f = f.Trim(' ', '\t', '=', '/', '-').ToLowerInvariant();

					if (f.StartsWith(@"de"))
					{
						Thread.CurrentThread.CurrentCulture =
							Thread.CurrentThread.CurrentUICulture =
							Application.CurrentCulture = new CultureInfo(@"de-DE");
					}
					else if (f.StartsWith(@"en"))
					{
						Thread.CurrentThread.CurrentCulture =
							Thread.CurrentThread.CurrentUICulture =
							Application.CurrentCulture = new CultureInfo(@"en-US");
					}
				}
			}
		}

		private static void initializeLanguage()
		{
			ApplyLanguageSettingsToCurrentThread();
		}

		private static void test()
		{
			//var s = Resources.SR_Test;
		}

		private static void currentDomainUnhandledException(
			object sender,
			UnhandledExceptionEventArgs e )
		{
			doHandleException( e.ExceptionObject as Exception );
		}

		private static void applicationThreadException(
			object sender,
			ThreadExceptionEventArgs e )
		{
			doHandleException( e.Exception );
		}

		private static void doHandleException(
			Exception e )
		{
			bool handleException;

		    var exception = e as MessageBoxException;
		    if ( exception != null )
			{
				var mbx = exception;

				XtraMessageBox.Show(
					mbx.Parent,
					mbx.Message,
					@"Zeta Resource Editor",
					mbx.Buttons,
					mbx.Icon );

				handleException = false;
			}
			else if ( e is PersistentPairStorageException )
			{
				// 2009-06-22, Uwe Keim:
				// http://zeta-producer.de/Pages/AdvancedForumIndex.aspx?DataID=9514
				LogCentral.Current.LogWarn(
					@"PersistentPairStorageException occurred.", e );

				if ( e.InnerException == null )
				{
					handleException = true;
				}
				else
				{
					if ( e.InnerException is UnauthorizedAccessException ||
						e.InnerException is IOException )
					{
						handleException = false;
					}
					else
					{
						handleException = true;
					}
				}
			}
			else
			{
				handleException = true;
			}

			// --

			if ( handleException )
			{
				LogCentral.Current.LogError( @"Exception occurred.", e );

				// Do not allow recursive exceptions, since the
				// Application.ThreadException would eat them anyway.
				try
				{
					// --

					using ( var form = new ErrorForm() )
					{
						form.Initialize( e );
						var result = form.ShowDialog( Form.ActiveForm );

						if ( result == DialogResult.Abort )
						{
							System.Diagnostics.Process.GetCurrentProcess().Kill();
							Application.Exit();
						}
					}
				}
				catch ( Exception x )
				{
					LogCentral.Current.LogError(
						@"Exception occurred during exception handling.",
						x );

					XtraMessageBox.Show(
						Form.ActiveForm,
						string.Format( @"{0}{1}{1}{2}",
							x.Message,
							Environment.NewLine,
							e.Message ),
						@"Zeta Resource Editor",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error );
				}
			}
		}

		private static void storageError(
			object sender,
			PersistentPairStorageErrorEventArgs args )
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

			/*
			if ( e.Exception == null )
			{
				e.Cancel = false;
			}
			else
			{
				// 2009-06-22, Uwe Keim:
				// http://zeta-producer.de/Pages/AdvancedForumIndex.aspx?DataID=9514
				LogCentral.Current.LogWarn(
					@"PersistentPairStorageException occurred.", e.Exception );

				if ( e.Exception.InnerException == null )
				{
					e.Cancel = true;
				}
				else
				{
					if ( e.Exception.InnerException is UnauthorizedAccessException ||
						e.Exception.InnerException is IOException )
					{
						e.Cancel = false;
					}
					else
					{
						e.Cancel = true;
					}
				}
			}*/
		}

		/// <summary>
		/// Gets the current user storage base folder path.
		/// </summary>
		/// <value>The current user storage base folder path.</value>
		public static ZlpDirectoryInfo CurrentUserStorageBaseFolderPath
		{
			get
			{
				if ( _cacheForCurrentUserStorageBaseFolderPath == null )
				{
					const string folderName = @"Zeta Resource Editor";

					var result = new ZlpDirectoryInfo(
						ZlpPathHelper.Combine(
							Environment.GetFolderPath(
								Environment.SpecialFolder.LocalApplicationData ),
							folderName ) );

					_cacheForCurrentUserStorageBaseFolderPath =
						CheckCreateFolder( result );
				}

				return _cacheForCurrentUserStorageBaseFolderPath;
			}
		}

		/// <summary>
		/// Checks and creates the folder if not yet exists.
		/// </summary>
		/// <param name="folderPath">The folder path.</param>
		/// <returns></returns>
		public static ZlpDirectoryInfo CheckCreateFolder(
			ZlpDirectoryInfo folderPath)
		{
			if ( folderPath != null && !folderPath.Exists )
			{
				folderPath.Create();
			}

			return folderPath;
		}

		public static bool WantDisplaySupportOptionsOnForms
		{
			get
			{
				return true;
			}
		}
	}
}