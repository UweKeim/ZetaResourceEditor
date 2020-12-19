namespace ZetaResourceEditor.UI.Main
{
    using System;
    using System.Net;
    using System.Windows.Forms;
    using Helper.Base;
    using RuntimeBusinessLogic.DL;
    using RuntimeBusinessLogic.WebServices;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class OptionsForm :
        FormBase
    {
        public OptionsForm()
        {
            InitializeComponent();

            if (!DesignMode)
            {
            }
        }

        public int ActiveTabPageIndex
        {
            get => xtraTabControl1.SelectedTabPageIndex;
            set => xtraTabControl1.SelectedTabPageIndex = value;
        }

        protected override void FillItemToControls()
        {
            base.FillItemToControls();

            panel1.BackColor = GridColors.CommentForeColor;
            panel2.BackColor = GridColors.CompleteRowEmptyForeColor;
            panel3.BackColor = GridColors.TagNameForeColor;
            panel4.BackColor = GridColors.NullCellBackColor;
            panel5.BackColor = GridColors.EmptyCellBackColor;
            panel6.BackColor = GridColors.PlaceHolderMismatchForeColor;
            panel7.BackColor = GridColors.TranslationErrorForeColor;
            panel8.BackColor = GridColors.TranslationSuccessForeColor;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            WinFormsPersistanceHelper.RestoreState(this);
            CenterToParent();

            InitiallyFillLists();
            FillItemToControls();

            UpdateUI();
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinFormsPersistanceHelper.SaveState(this);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FillControlsToItem();
        }

        private void proxyButton_Click(object sender, EventArgs e)
        {
            using var form = new WebProxySettingsForm();
            form.WebProxy = WebServiceManager.Current.WebServiceProxy as WebProxy;
            form.WebProxyUsage = WebServiceManager.Current.WebProxyUsage;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                WebServiceManager.Current.WebServiceProxy = form.WebProxy;
                WebServiceManager.Current.WebProxyUsage = form.WebProxyUsage;
            }
        }
    }
}