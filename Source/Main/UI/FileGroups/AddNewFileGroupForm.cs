namespace ZetaResourceEditor.UI.FileGroups;

using Helper;
using Helper.Base;
using Helper.ErrorHandling;
using Helper.Progress;
using Main;
using Properties;
using RuntimeBusinessLogic.FileGroups;
using RuntimeBusinessLogic.FileInformations;
using RuntimeBusinessLogic.Language;
using RuntimeBusinessLogic.ProjectFolders;
using RuntimeBusinessLogic.Projects;
using System.Linq;

public partial class AddNewFileGroupForm :
    FormBase
{
    private Project _project;
    private ProjectFolder _projectFolder;

    public AddNewFileGroupForm()
    {
        InitializeComponent();
    }

    public void Initialize(
        Project project,
        ProjectFolder projectFolder)
    {
        _project = project;
        _projectFolder = projectFolder;
    }

    protected override void InitiallyFillLists()
    {
        var plc = projectLanguageCodes;
        var plcl = new List<string?>(plc);

        var items = new List<MyTuple<string, CultureInfo>>();

        // ReSharper disable LoopCanBeConvertedToQuery
        foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            // ReSharper restore LoopCanBeConvertedToQuery
        {
            items.Add(
                new(
                    $@"{(plcl.Contains(culture.Name.ToLowerInvariant()) ? @"* " : string.Empty)}{culture.DisplayName} [{
                        culture.Name
                    }]",
                    culture));
        }

        items.Sort((x, y) => string.CompareOrdinal(x.Item1, y.Item1));

        foreach (var item in items)
        {
            destinationLanguagesListBox.Items.Add(item);
        }
    }

    public override void UpdateUI()
    {
        base.UpdateUI();

        invertFileGroupsButton.Enabled =
            destinationLanguagesListBox.Items.Count > 0;
        selectNoFileGroupsButton.Enabled =
            destinationLanguagesListBox.CheckedItems.Count > 0;
        selectAllFileGroupsButton.Enabled =
            destinationLanguagesListBox.Items.Count > 0 &&
            destinationLanguagesListBox.CheckedItems.Count <
            destinationLanguagesListBox.Items.Count;

        buttonOK.Enabled =
            extensionComboBoxEdit.SelectedIndex >= 0 &&
            destinationLanguagesListBox.CheckedItems.Count > 0 &&
            baseFileNameTextEdit.Text.Trim().Length > 0;
    }

    protected override void FillItemToControls()
    {
        base.FillItemToControls();

        parentElementTextBox.Text =
            _projectFolder == null
                ? _project.Name
                : _projectFolder.NameIntelli;

        // --

        var storage =
            MainForm.Current.ProjectFilesControl.Project.DynamicSettingsGlobalHierarchical;

        DevExpressExtensionMethods.RestoreSettings(
            destinationLanguagesListBox,
            storage,
            @"AddNewFileGroupForm.destinationLanguagesListBox");

        extensionComboBoxEdit.SelectedIndex =
            ConvertHelper.ToInt32(PersistanceHelper.RestoreValue(
                storage,
                @"AddNewFileGroupForm.extensionComboBoxEdit",
                0));

        baseFolderTextEdit.Text =
            ConvertHelper.ToString(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"AddNewFileGroupForm.baseFolderTextEdit.Text",
                    baseFolderTextEdit.Text));

        baseFileNameTextEdit.Text =
            ConvertHelper.ToString(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"AddNewFileGroupForm.baseFileNameTextEdit.Text",
                    baseFileNameTextEdit.Text));
    }

    protected override void FillControlsToItem()
    {
        base.FillControlsToItem();

        var storage =
            MainForm.Current.ProjectFilesControl.Project.DynamicSettingsGlobalHierarchical;

        DevExpressExtensionMethods.PersistSettings(
            destinationLanguagesListBox,
            storage,
            @"AddNewFileGroupForm.destinationLanguagesListBox");
        PersistanceHelper.SaveValue(
            storage,
            @"AddNewFileGroupForm.extensionComboBoxEdit",
            extensionComboBoxEdit.SelectedIndex.ToString(CultureInfo.InvariantCulture));

        PersistanceHelper.SaveValue(
            storage,
            @"AddNewFileGroupForm.baseFolderTextEdit.Text",
            baseFolderTextEdit.Text);

        PersistanceHelper.SaveValue(
            storage,
            @"AddNewFileGroupForm.baseFileNameTextEdit.Text",
            baseFileNameTextEdit.Text);
    }

    private void CreateNewFileForm_Load(object sender, EventArgs e)
    {
        WinFormsPersistanceHelper.RestoreState(this);
        CenterToParent();

        InitiallyFillLists();
        FillItemToControls();

        UpdateUI();
    }

    private void CreateNewFileForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        WinFormsPersistanceHelper.SaveState(this);
        FillControlsToItem();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        Result = null;

        using (new WaitCursor(this, WaitCursorOption.ShortSleep))
        {
            var cultures = getCultures();

            var baseFolderPath = baseFolderTextEdit.Text.Trim();
            var baseFileName = baseFileNameTextEdit.Text.Trim();

            var extension = @"." + extensionComboBoxEdit.Text.Trim('.');

            var created = 0;

            using (new BackgroundWorkerLongProgressGui(
                       delegate (object snd, DoWorkEventArgs _)
                       {
                           try
                           {
                               var bw = (BackgroundWorker)snd;

                               // --
                               // First pass, add all in-memory to check for same file group.

                               var fg = new FileGroup(_project);

                               if (cultures != null)
                               {
                                   foreach (var culture in cultures)
                                   {
                                       var fileName =
                                           _project.IsNeutralLanguage(culture)
                                               ? baseFileName + extension
                                               : generateFileName(fg, culture);

                                       fg.Add(new(fg)
                                       {
                                           File = new(fileName)
                                       });
                                   }

                                   // Look for same entries.
                                   if (_project.FileGroups.HasFileGroupWithChecksum(
                                           fg.GetChecksum(_project)))
                                   {
                                       throw new MessageBoxException(
                                           this,
                                           Resources.SR_ProjectFilesUserControl_AddResourceFilesWithDialog_ExistsInTheProject,
                                           MessageBoxIcon.Information);
                                   }
                                   else
                                   {
                                       // --
                                       // Second pass, add all existing.

                                       fg = new(_project);

                                       foreach (var culture in cultures)
                                       {
                                           if (bw.CancellationPending)
                                           {
                                               throw new OperationCanceledException();
                                           }

                                           var fileName =
                                               _project.IsNeutralLanguage(culture)
                                                   ? baseFileName + extension
                                                   : generateFileName(fg, culture);

                                           FileInformation ffi;

                                           if (_project.IsNeutralLanguage(culture))
                                           {
                                               ffi = new(fg)
                                               {
                                                   File = new(ZspPathHelper.Combine(baseFolderPath, fileName))
                                               };
                                               fg.Add(ffi);
                                           }
                                           else
                                           {
                                               ffi =
                                                   fg.CreateAndAddNewFile(
                                                       baseFolderPath,
                                                       fileName);
                                           }

                                           // Must create real file.
                                           File.WriteAllText(ffi.File.FullName, Resources.SR_EmptyResourceFile);

                                           created++;
                                       }
                                   }
                               }

                               if (_projectFolder != null)
                               {
                                   fg.ProjectFolder = _projectFolder;
                               }

                               _project.FileGroups.Add(fg);
                               _project.MarkAsModified();

                               Result = fg;

                           }
                           catch (OperationCanceledException)
                           {
                               // Ignore.
                           }
                       },
                       Resources.SR_CreateNewFilesForm_Creating,
                       BackgroundWorkerLongProgressGui.CancellationMode.Cancelable,
                       this))
            {
            }

            // --

            XtraMessageBox.Show(
                this,
                string.Format(
                    Resources.SR_CreateNewFilesForm_Finished03,
                    created),
                @"Zeta Resource Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private CultureInfo[] getCultures()
    {
        var list = new List<CultureInfo>();

        // ReSharper disable LoopCanBeConvertedToQuery
        foreach (CheckedListBoxItem item in destinationLanguagesListBox.CheckedItems)
            // ReSharper restore LoopCanBeConvertedToQuery
        {
            var p = (MyTuple<string, CultureInfo>)item.Value;

            list.Add(p.Item2);
        }

        list.Sort(
            (x, y) =>
            {
                if (x.Name == y.Name)
                {
                    return 0;
                }
                else
                {
                    if (_project.IsNeutralLanguage(x))
                    {
                        return -1;
                    }
                    else if (_project.IsNeutralLanguage(y))
                    {
                        return +1;
                    }
                    else
                    {
                        return string.CompareOrdinal(x.Name, y.Name);
                    }
                }
            });

        return list.ToArray();
    }

    private static string? generateFileName(
        FileGroup fileGroup,
        CultureInfo culture)
    {
        var pattern =
            new LanguageCodeDetection(fileGroup.Project).IsNeutralCulture(
                fileGroup.ParentSettings,
                culture)
                ? fileGroup.Project.NeutralLanguageFileNamePattern
                : fileGroup.Project.NonNeutralLanguageFileNamePattern;

        pattern = pattern.Replace(@"[basename]", fileGroup.BaseName);
        pattern = pattern.Replace(@"[languagecode]", culture.Name);
        pattern = pattern.Replace(@"[extension]", fileGroup.BaseExtension);
        pattern = pattern.Replace(@"[optionaldefaulttypes]", fileGroup.BaseOptionalDefaultType);

        return pattern;
    }

    private void destinationLanguagesListBox_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
    {
        UpdateUI();
    }

    private void selectAllFileGroupsButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
        {
            destinationLanguagesListBox.SetItemChecked(index, true);
        }
    }

    private void selectNoFileGroupsButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
        {
            destinationLanguagesListBox.SetItemChecked(index, false);
        }
    }

    private void invertFileGroupsButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
        {
            destinationLanguagesListBox.SetItemChecked(
                index,
                !destinationLanguagesListBox.GetItemChecked(index));
        }
    }

    private void destinationLanguagesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void selectProjectLanguagesButton_Click(object sender, EventArgs e)
    {
        var plc = projectLanguageCodes;
        var plcl = new List<string?>(plc);

        for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
        {
            var p = (MyTuple<string, CultureInfo>)((CheckedListBoxItem)destinationLanguagesListBox.GetItem(index)).Value;

            destinationLanguagesListBox.SetItemChecked(
                index,
                plcl.Contains(p.Item2.Name.ToLowerInvariant()));
        }
    }

    private IEnumerable<string?> projectLanguageCodes
    {
        get
        {
            var codes =
                new HashSet<string?>
                {
                    _project.NeutralLanguageCode
                };

            foreach (var group in _project.FileGroups)
            {
                foreach (var lc in group.GetLanguageCodes(_project))
                {
                    if (!string.IsNullOrEmpty(lc))
                    {
                        codes.Add(lc);
                    }
                }
            }

            var l = codes.ToList();
            l.Sort();

            return l.ToArray();
        }
    }

    public FileGroup Result { get; private set; }

    private void baseFileNameTextEdit_EditValueChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void baseFolderSelectButton_Click(object sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog
        {
            Description = Resources
                .AddNewFileGroupForm_baseFolderSelectButton_Click_Please_select_the_base_folder_where_to_create_the_files_
        };

        var initialDir =
            ConvertHelper.ToString(
                PersistanceHelper.RestoreValue(
                    MainForm.UserStorageIntelligent,
                    @"filesInitialDir"));

        if (string.IsNullOrEmpty(initialDir) || !Directory.Exists(initialDir))
        {
            var d = _project.ProjectConfigurationFilePath.Directory;
            initialDir = d.FullName;
        }

        dialog.SelectedPath = initialDir;
        //dialog.ShowEditBox = true;

        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
            PersistanceHelper.SaveValue(
                MainForm.UserStorageIntelligent,
                @"filesInitialDir",
                dialog.SelectedPath);

            baseFolderTextEdit.Text = dialog.SelectedPath;

            UpdateUI();
        }
    }

}