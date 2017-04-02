namespace ZetaResourceEditor.UI.ExportImportExcel
{
    using Helper.Base;
    using System;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class ExcelImportFormatInformationForm :
        FormBase
    {
        public ExcelImportFormatInformationForm()
        {
            InitializeComponent();
        }

        private void ImportFormatInformationForm_Load(object sender, EventArgs e)
        {
            WinFormsPersistanceHelper.RestoreState(this);
            CenterToParent();

            InitiallyFillLists();
            FillItemToControls();

            UpdateUI();
        }

        private void ImportFormatInformationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinFormsPersistanceHelper.SaveState(this);
        }
    }
}