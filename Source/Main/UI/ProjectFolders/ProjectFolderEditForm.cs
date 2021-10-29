namespace ZetaResourceEditor.UI.ProjectFolders;

using Helper.Base;
using Properties;
using RuntimeBusinessLogic.ProjectFolders;
using System;
using System.Windows.Forms;
using Zeta.VoyagerLibrary.WinForms.Persistance;

public partial class ProjectFolderEditForm :
    FormBase
{
    private ProjectFolder _projectFolder;

    public ProjectFolderEditForm()
    {
        InitializeComponent();
        createToolTips();
    }

    /// <summary>
    /// Since the strings constantly get lost, create
    /// them in code instead in the designer.
    /// </summary>
    private void createToolTips()
    {
        var superToolTip4 = new DevExpress.Utils.SuperToolTip();
        var toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
        var toolTipItem4 = new DevExpress.Utils.ToolTipItem();

        var superToolTip5 = new DevExpress.Utils.SuperToolTip();
        var toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
        var toolTipItem5 = new DevExpress.Utils.ToolTipItem();

        var superToolTip6 = new DevExpress.Utils.SuperToolTip();
        var toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
        var toolTipItem6 = new DevExpress.Utils.ToolTipItem();

        // --

        toolTipTitleItem4.Text = Resources.SR_toolTipTitleItem4Text;
        toolTipItem4.Text = Resources.SR_toolTipItem4Text;
        superToolTip4.Items.Add(toolTipTitleItem4);
        superToolTip4.Items.Add(toolTipItem4);
        defaultToolTipController1.SetSuperTip(pictureBox8, superToolTip4);

        toolTipTitleItem5.Text = Resources.SR_toolTipTitleItem5Text;
        toolTipItem5.Text = Resources.SR_toolTipItem5Text;
        superToolTip5.Items.Add(toolTipTitleItem5);
        superToolTip5.Items.Add(toolTipItem5);
        defaultToolTipController1.SetSuperTip(pictureBox6, superToolTip5);

        toolTipTitleItem6.Text = Resources.SR_toolTipTitleItem6Text;
        toolTipItem6.Text = Resources.SR_toolTipItem6Text;
        superToolTip6.Items.Add(toolTipTitleItem6);
        superToolTip6.Items.Add(toolTipItem6);
        defaultToolTipController1.SetSuperTip(pictureBox7, superToolTip6);
    }

    public override void UpdateUI()
    {
        base.UpdateUI();

        discreteFilePatternSettingsPanel.Enabled =
            useTheFollowingFilePatternSettingsCheckEdit.Checked;
        buttonOK.Enabled = nameTextBox.Text.Trim().Length > 0;
    }

    private void ProjectFolderEditForm_Load(
        object sender,
        EventArgs e)
    {
        WinFormsPersistanceHelper.RestoreState(this);
        CenterToParent();

        parentTextBox.Text =
            _projectFolder.Parent == null
                ? _projectFolder.Project.Name
                : _projectFolder.Parent.NameIntelli;

        nameTextBox.Text = _projectFolder.Name;

        neutralLanguageFileNamePatternTextEdit.Text = _projectFolder.NeutralLanguageFileNamePattern;
        nonNeutralLanguageFileNamePatternTextEdit.Text = _projectFolder.NonNeutralLanguageFileNamePattern;
        baseNameDotCountSpinEdit.Value = _projectFolder.BaseNameDotCount;
        defaultTypesTextEdit.Text = _projectFolder.DefaultFileTypesToIgnore;

        useParentElementsFilePatternSettingsCheckEdit.Checked =
            _projectFolder.UseParentFilePatternSettings;
        useTheFollowingFilePatternSettingsCheckEdit.Checked =
            !_projectFolder.UseParentFilePatternSettings;

        ignoreChildsDuringExportAndImportCheckEdit.Checked =
            _projectFolder.IgnoreDuringExportAndImport;

        checkFillFromParent();
        UpdateUI();
    }

    private void ProjectFolderEditForm_FormClosing(
        object sender,
        FormClosingEventArgs e)
    {
        WinFormsPersistanceHelper.SaveState(this);
    }

    public void Initialize(ProjectFolder projectFolder)
    {
        _projectFolder = projectFolder;
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        _projectFolder.Name = nameTextBox.Text;

        _projectFolder.UseParentFilePatternSettings =
            useParentElementsFilePatternSettingsCheckEdit.Checked;

        _projectFolder.NeutralLanguageFileNamePattern = neutralLanguageFileNamePatternTextEdit.Text.Trim();
        _projectFolder.NonNeutralLanguageFileNamePattern = nonNeutralLanguageFileNamePatternTextEdit.Text.Trim();
        _projectFolder.BaseNameDotCount = (int)baseNameDotCountSpinEdit.Value;
        _projectFolder.DefaultFileTypesToIgnore = defaultTypesTextEdit.Text.Trim();
        _projectFolder.IgnoreDuringExportAndImport = ignoreChildsDuringExportAndImportCheckEdit.Checked;

        _projectFolder.Project.MarkAsModified();
    }

    private void nameTextBox_EditValueChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void ProjectFolderEditForm_Shown(object sender, EventArgs e)
    {
        nameTextBox.Focus();
    }

    private void useParentElementsFilePatternSettingsCheckEdit_CheckedChanged(
        object sender,
        EventArgs e)
    {
        UpdateUI();

        checkFillFromParent();
    }

    private void useTheFollowingFilePatternSettingsCheckEdit_CheckedChanged(
        object sender,
        EventArgs e)
    {
        UpdateUI();

        checkFillFromParent();
    }

    private void checkFillFromParent()
    {
        if (useParentElementsFilePatternSettingsCheckEdit.Checked)
        {
            var ps = _projectFolder.ParentSettings;
            if (ps != null)
            {
                neutralLanguageFileNamePatternTextEdit.Text = ps.EffectiveNeutralLanguageFileNamePattern;
                nonNeutralLanguageFileNamePatternTextEdit.Text = ps.EffectiveNonNeutralLanguageFileNamePattern;
                baseNameDotCountSpinEdit.Value = ps.EffectiveBaseNameDotCount;
                defaultTypesTextEdit.Text = ps.EffectiveDefaultFileTypesToIgnore;
            }
        }
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
}