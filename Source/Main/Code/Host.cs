namespace ZetaResourceEditor.Code
{
    using DevExpress.XtraEditors;
    using ExtendedControlsLibrary.Skinning;
    using Properties;
    using RuntimeBusinessLogic.Projects;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using UI.Helper.ErrorHandling;
    using UI.Main;
    using Zeta.VoyagerLibrary.Logging;
    using Zeta.VoyagerLibrary.Tools.Miscellaneous;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using ZetaLongPaths;

    internal sealed class Host
    {
        private static readonly IDictionary<string, Assembly> _additional =
            new Dictionary<string, Assembly>();

        private static ZlpDirectoryInfo _cacheForCurrentUserStorageBaseFolderPath;

        [STAThread]
        private static void Main()
        {
            try
            {
                BindingRedirectsHelper.Initialize();

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
                            ZlpPathHelper.Combine(
                                CurrentUserStorageBaseFolderPath.FullName,
                                @"zeta-resource-editor-settings.xml")
                    };
                persistentStorage.Error += storageError;

                PersistanceHelper.Storage = persistentStorage;

                // --

                // http://community.devexpress.com/forums/t/80133.aspx

                SkinHelper.InitializeAll();

                // --

                AppDomain.CurrentDomain.UnhandledException += currentDomainUnhandledException;
                Application.ThreadException += applicationThreadException;

                // --
                // http://stackoverflow.com/a/9180843/107625

                var dir = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location ?? string.Empty);
                foreach (var assemblyName in Directory.GetFiles(dir ?? string.Empty, @"*.dll"))
                {
                    try
                    {
                        var assembly = Assembly.LoadFile(assemblyName);
                        _additional.Add(assembly.GetName().Name, assembly);
                    }
                    catch (BadImageFormatException)
                    {
                        // Ignorieren.
                    }
                }

                AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ResolveAssembly;
                AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_ResolveAssembly;

                // --

                test();

                initializeLanguage();

                Application.Run(new MainForm());
            }
            catch (Exception x)
            {
                doHandleException(x);
            }
        }

        private static Assembly CurrentDomain_ResolveAssembly(object sender, ResolveEventArgs e)
        {
            // Hier mache ich quasi mein eigenes, automatisches, Binding-Redirect.
            // (z.B. Newtonsoft.Json 6.0.0.0 nach 9.0.0.0).

            if (e.Name.IndexOf(',') < 0) return null;

            var name = e.Name.Substring(0, e.Name.IndexOf(','));

            _additional.TryGetValue(name, out var res);
            return res;
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
            Exception e)
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
                case PersistentPairStorageException _:
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
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
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
                            e.Message),
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private static void storageError(
            object sender,
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

        public static ZlpDirectoryInfo CurrentUserStorageBaseFolderPath
        {
            get
            {
                if (_cacheForCurrentUserStorageBaseFolderPath == null)
                {
                    const string folderName = @"Zeta Resource Editor";

                    var result = new ZlpDirectoryInfo(
                        ZlpPathHelper.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData),
                            folderName));

                    _cacheForCurrentUserStorageBaseFolderPath = result.CheckCreate();
                }

                return _cacheForCurrentUserStorageBaseFolderPath;
            }
        }
    }
}