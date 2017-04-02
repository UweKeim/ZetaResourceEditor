namespace ZetaResourceEditor.UI.FileGroups
{
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using Helper;
    using Helper.Base;
    using Helper.Progress;
    using Main;
    using RuntimeBusinessLogic.ProjectFolders;
    using RuntimeBusinessLogic.Projects;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common.Collections;
    using Zeta.VoyagerLibrary.WinForms.Common;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class DeleteLanguageForm :
        FormBase
    {
        private Project _project;
        private ProjectFolder _projectFolder;

        public DeleteLanguageForm()
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
            var plcl = new List<string>(plc);

            var items = new List<MyTuple<string, CultureInfo>>();

            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                if (plcl.Contains(culture.Name.ToLowerInvariant()))
                {
                    items.Add(new MyTuple<string, CultureInfo>($@"{culture.DisplayName} [{culture.Name}]", culture));
                }
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
                destinationLanguagesListBox.CheckedItems.Count > 0;
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
                (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).DynamicSettingsGlobalHierarchical;

            DevExpressExtensionMethods.RestoreSettings(
                destinationLanguagesListBox,
                storage,
                @"DeleteLanguageForm.destinationLanguagesListBox");
        }

        protected override void FillControlsToItem()
        {
            base.FillControlsToItem();

            var storage =
                (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).DynamicSettingsGlobalHierarchical;

            DevExpressExtensionMethods.PersistSettings(
                destinationLanguagesListBox,
                storage,
                @"DeleteLanguageForm.destinationLanguagesListBox");
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
            using (new WaitCursor(this, WaitCursorOption.ShortSleep))
            {
                var cultures = getCultures();

                var processed = 0;
                var skipped = 0;
                var deleted = 0;
                var notdeleted = 0;

                using (new BackgroundWorkerLongProgressGui(
                    delegate (object snd, DoWorkEventArgs args)
                    {
                        try
                        {
                            var bw = (BackgroundWorker)snd;

                            var fgs =
                                _projectFolder == null
                                    ? _project.FileGroups
                                    : _projectFolder.FileGroupsDeep;

                            foreach (var fg in fgs)
                            {
                                if (bw.CancellationPending)
                                {
                                    throw new OperationCanceledException();
                                }

                                foreach (var culture in cultures)
                                {
                                    if (fg.HasLanguageCode(culture))
                                    {
                                        var sourceFile = fg.GetFileByLanguageCode(_project, culture);
                                        //CHANGED BY Member 802361 check for nulls. It is possible there is no reference resource
                                        //we can either create or just skip. I choose skip because without base resx there is no sense.
                                        if (sourceFile == null)
                                        {
                                            skipped++;
                                        }
                                        else
                                        {
                                            var didDelete = fg.DeleteFile(sourceFile);

                                            if (didDelete) deleted++;
                                            else notdeleted++;

                                            processed++;
                                        }
                                    }
                                    else
                                    {
                                        skipped++;
                                    }
                                }
                            }
                        }
                        catch (OperationCanceledException)
                        {
                            // Ignore.
                        }
                    },
                    "Deleting files…",
                    BackgroundWorkerLongProgressGui.CancellationMode.Cancelable,
                    this))
                {
                }

                // --

                if (deleted <= 0) //
                {
                    XtraMessageBox.Show(
                        this,
                        "The operation finished successfully, however no files were deleted.",
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    UpdateUI();
                }
                else if (processed > 0 && skipped > 0)
                {
                    XtraMessageBox.Show(
                        this,
                        $"The operation finished successfully. {processed} files were processed, {skipped} files were skipped, {deleted} files were deleted.",
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if (notdeleted > 0)
                {
                    XtraMessageBox.Show(
                        this,
                        $"The operation finished successfully. {processed} files were processed, of which {deleted} files were deleted and {notdeleted} files were not deleted.",
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show(
                        this,
                        $"The operation finished successfully. {deleted} files were deleted.",
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
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

            return list.ToArray();
        }

        private void destinationLanguagesListBox_ItemCheck(object sender,
            DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
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

        private IEnumerable<string> projectLanguageCodes
        {
            get
            {
                var codes =
                    new HashSet<string>
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
    }
}