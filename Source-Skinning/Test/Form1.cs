namespace Test
{
    using System;
    using DevExpress.XtraWizard;
    using ExtendedControlsLibrary.General.Base;

    public partial class Form1 :
        DevExpressXtraFormBase
    {
        public Form1()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                InitAppearances();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void InitAppearances()
        {
        }

        private void noHeaderWizardControl1_CustomizeCommandButtons(object sender, CustomizeCommandButtonsEventArgs e)
        {
            e.FinishButton.Visible = false;

            if (e.Page == welcomeWizardPage1)
            {
                e.PrevButton.Visible = false;
                e.NextButton.Text = "Start";
            }
            else if (e.Page == wizardPage1)
            {
                e.PrevButton.Visible = true;
                e.CancelButton.Visible = false;
            }

        }
    }
}