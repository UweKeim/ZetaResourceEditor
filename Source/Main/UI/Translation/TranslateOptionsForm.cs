namespace ZetaResourceEditor.UI.Translation;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ExtendedControlsLibrary;
using Helper.Base;
using RuntimeBusinessLogic.Helpers;
using RuntimeBusinessLogic.Projects;
using RuntimeBusinessLogic.Translation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Zeta.VoyagerLibrary.Common;
using Zeta.VoyagerLibrary.WinForms.Persistance;

public partial class TranslateOptionsForm :
    FormBase
{
    private Project _project;
    private int _initialIndex;
    private int _beforeIndex = -1;

    public TranslateOptionsForm()
    {
        InitializeComponent();

        if (!DesignModeHelper.IsDesignMode)
        {
            // Positioning the multi-line text box.

            var delta = appIDMemoEdit.Top - appIDTextEdit.Top;
            appIDMemoEdit.Top = appIDTextEdit.Top;
            appIDMemoEdit.Height += delta;
        }
    }

    private class EngineHelper
    {
        public ITranslationEngine Engine { get; }

        public EngineHelper(
            ITranslationEngine engine)
        {
            Engine = engine;
        }

        public override string ToString()
        {
            return Engine.UserReadableName;
        }
    }

    public bool TranslationProviderChanged =>
        engineComboBox.SelectedIndex != _initialIndex ||
        appIDTextEdit.Text.Trim() != _initialAppID;

    protected override void InitiallyFillLists()
    {
        base.InitiallyFillLists();

        foreach (var engine in TranslationHelper.Engines)
        {
            engineComboBox.Properties.Items.Add(new EngineHelper(engine));
        }
    }

    protected override void FillItemToControls()
    {
        base.FillItemToControls();

        translationDelayTextEdit.Text =
            _project.TranslationDelayMilliseconds.ToString(CultureInfo.InvariantCulture);
        checkEditContinueOnErrors.Checked =
            _project.TranslationContinueOnErrors;
        wordsToProtectMemoEdit.Text =
            string.Join(Environment.NewLine, _project.TranslationWordsToProtect);
        wordsToRemoveMemoEdit.Text =
            string.Join(Environment.NewLine, _project.TranslationWordsToRemove);

        selectEngine(_project.TranslationEngineUniqueInternalName);
        _initialIndex = engineComboBox.SelectedIndex;

        _localDic = _project.TranslationAppIDs;

        loadAppID(engineComboBox.SelectedIndex);

        _initialAppID = appIDTextEdit.Text.Trim();
    }

    private void selectEngine(string un)
    {
        foreach (EngineHelper eh in engineComboBox.Properties.Items)
        {
            if (string.Compare(eh.Engine.UniqueInternalName, un, StringComparison.OrdinalIgnoreCase) == 0)
            {
                engineComboBox.SelectedItem = eh;
                return;
            }
        }

        // Not found, select default.
        foreach (EngineHelper eh in engineComboBox.Properties.Items)
        {
            if (eh.Engine.IsDefault)
            {
                engineComboBox.SelectedItem = eh;
                return;
            }
        }
    }

    protected override void FillControlsToItem()
    {
        base.FillControlsToItem();

        _project.TranslationDelayMilliseconds = ConvertHelper.ToInt32(translationDelayTextEdit.Text.Trim());
        _project.TranslationContinueOnErrors = checkEditContinueOnErrors.Checked;
        _project.TranslationEngineUniqueInternalName =
            ((EngineHelper)engineComboBox.SelectedItem).Engine.UniqueInternalName;
        _project.TranslationWordsToProtect = wordsToProtectMemoEdit.Text.Trim().Split(new[] { Environment.NewLine },
            StringSplitOptions.RemoveEmptyEntries);
        _project.TranslationWordsToRemove = wordsToRemoveMemoEdit.Text.Trim().Split(new[] { Environment.NewLine },
            StringSplitOptions.RemoveEmptyEntries);

        saveAppID(engineComboBox.SelectedIndex);

        _project.TranslationAppIDs = _localDic;

        TranslationHelper.ResetSelectedEngine();
    }

    public override void UpdateUI()
    {
        base.UpdateUI();

        buttonOK.Enabled =
            ConvertHelper.IsInt32(translationDelayTextEdit.Text.Trim()) &&
            ConvertHelper.ToInt32(translationDelayTextEdit.Text.Trim()) > 0 &&
            ConvertHelper.ToInt32(translationDelayTextEdit.Text.Trim()) < 50000;
    }

    private void AutoTranslateOptionsForm_Load(
        object sender,
        EventArgs e)
    {
        _appIDLabelText = appIDLabel.Text;

        WinFormsPersistanceHelper.RestoreState(this);
        CenterToParent();

        InitiallyFillLists();
        FillItemToControls();

        engineComboBox_SelectedIndexChanged(null, null);

        UpdateUI();
    }

    private void AutoTranslateOptionsForm_FormClosing(
        object sender,
        FormClosingEventArgs e)
    {
        WinFormsPersistanceHelper.SaveState(this);
    }

    private void translationDelayTextEdit_EditValueChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        FillControlsToItem();
    }

    public void Initialize(Project project)
    {
        // The translation stuff is streamed through the project but
        // actually stored in the global settings.
        _project = project ?? Project.Empty;
    }

    private void buttonAddDefaultWordsToKeep_Click(object sender, EventArgs e)
    {
        var current =
            new List<string>(
                wordsToProtectMemoEdit.Text.Trim().Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries));

        for (var i = 0; i < current.Count; i++)
        {
            current[i] = current[i].Trim();
        }

        current.RemoveAll(string.IsNullOrEmpty);

        // --

        foreach (var wtp in Project.DefaultWordsToProtect)
        {
            if (!current.Contains(wtp))
            {
                current.Add(wtp);
            }
        }

        wordsToProtectMemoEdit.Text =
            string.Join(Environment.NewLine, current.ToArray());
    }

    private void engineComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        saveAppID(_beforeIndex);
        _beforeIndex = engineComboBox.SelectedIndex;
        loadAppID(engineComboBox.SelectedIndex);

        updateAppIDLink();
    }

    private void updateAppIDLink()
    {
        if (engineComboBox.SelectedIndex >= 0 &&
            engineComboBox.SelectedIndex < engineComboBox.Properties.Items.Count)
        {
            appIDLinkControl.Visible = true;
        }
        else
        {
            appIDLinkControl.Visible = false;
        }
    }

    private void loadAppID(int engineComboBoxIndex)
    {
        if (engineComboBoxIndex >= 0 && engineComboBoxIndex < engineComboBox.Properties.Items.Count)
        {
            var dic = _localDic;
            if (dic is { Count: > 0 })
            {
                var eh = (EngineHelper)engineComboBox.Properties.Items[engineComboBoxIndex];

                appIDTextEdit.Text = dic.TryGetValue(eh.Engine.UniqueInternalName, out var appID)
                    ? appID
                    : string.Empty;
                appIDMemoEdit.Text = dic.TryGetValue(eh.Engine.UniqueInternalName, out appID)
                    ? appID
                    : string.Empty;

                appIDLabel.Text = string.Format(_appIDLabelText, eh.Engine.AppID1Name);

                appIDTextEdit.Visible = !eh.Engine.IsAppIDMultiLine;
                appIDMemoEdit.Visible = eh.Engine.IsAppIDMultiLine;
                myHyperLinkEdit1.Visible = eh.Engine.IsJson;
            }
        }
        else
        {
            appIDTextEdit.Text = string.Empty;
        }
    }

    private void saveAppID(int engineComboBoxIndex)
    {
        if (engineComboBoxIndex >= 0 && engineComboBoxIndex < engineComboBox.Properties.Items.Count)
        {
            var eh = (EngineHelper)engineComboBox.Properties.Items[engineComboBoxIndex];
            var key = eh.Engine.UniqueInternalName;

            var dic = _localDic;
            dic[key] = eh.Engine.IsAppIDMultiLine ? appIDMemoEdit.Text.Trim() : appIDTextEdit.Text.Trim();
            _localDic = dic;

            if (eh.Engine.IsJson && !string.IsNullOrWhiteSpace(appIDMemoEdit.Text.Trim()) &&
                !JsonHelper.IsValidJson(appIDMemoEdit.Text.Trim()))
            {
                XtraMessageBox.Show(
                    ActiveForm,
                    "Your entered JSON seems to be invalid. Please ensure that you enter a valid JSON document.",
                    @"Zeta Resource Editor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }

    private Dictionary<string, string> _localDic;
    private string _appIDLabelText;
    private string _initialAppID;

    private void appIDLinkControl_OpenLink(object sender, OpenLinkEventArgs e)
    {
        e.Handled = true;

        if (engineComboBox.SelectedIndex >= 0 &&
            engineComboBox.SelectedIndex < engineComboBox.Properties.Items.Count)
        {
            var eh = (EngineHelper)engineComboBox.Properties.Items[engineComboBox.SelectedIndex];

            Process.Start(eh.Engine.AppIDLink);
        }
    }

    private void TranslateOptionsForm_Shown(object sender, EventArgs e)
    {
        AutoTranslateForm.CheckShowNewTranslationInfos();
    }

    private void myHyperLinkEdit1_OpenLink(object sender, OpenLinkEventArgs e)
    {
        e.Handled = true;
        Process.Start(@"http://zeta.li/json-validator");
    }
}