namespace ExtendedControlsLibrary.Skinning.CustomWizard
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Reflection;
    using DevExpress.XtraWizard;

    internal class NoHeaderWizardAeroModel :
        WizardViewInfo.WizardAeroModel
    {
        public NoHeaderWizardAeroModel(WizardViewInfo v)
            : base(v)
        {
        }

        internal static bool IsGerman =>
            CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.StartsWith(@"de",
                StringComparison
                    .InvariantCultureIgnoreCase);

        public override Rectangle GetBackButtonBounds()
        {
            return new Rectangle(-50, -50, 32, 32);
            //return base.GetBackButtonBounds();
        }

        //public override Rectangle GetBackButtonBounds()
        //{
        //    //return base.GetBackButtonBounds();

        //    var b = base.GetBackButtonBounds();

        //    b.Width = IsGerman ? 85 : 75;
        //    b.Height = 28;

        //    return b;
        //}

        public override void UpdateButtonsLocation()
        {
            base.UpdateButtonsLocation();

            var fi = typeof (WizardViewInfo).GetField(@"prevButtonInfo", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fi != null)
            {
                var prevButtonInfo = (ButtonInfo) fi.GetValue(ViewInfo);

                fi = typeof (WizardViewInfo).GetField(@"nextButtonInfo", BindingFlags.Instance | BindingFlags.NonPublic);
                if (fi != null)
                {
                    var nextButtonInfo = (ButtonInfo) fi.GetValue(ViewInfo);

                    prevButtonInfo.Location = new Point(
                        nextButtonInfo.Location.X - prevButtonInfo.Size.Width - 4,
                        GetCommandButtonTopLocation(prevButtonInfo));
                }
            }
        }

        private int GetCommandButtonTopLocation(ButtonInfo button)
        {
            return ((NoHeaderWizardViewInfo) ViewInfo).GetOwnerInternal().ClientRectangle.Bottom -
                   WizardBaseConsts.CommandAreaHeight/2 - button.Size.Height/2;
        }

        public override Rectangle GetTitleBarBounds()
        {
            return Rectangle.Empty;
        }

        public override Rectangle GetContentBounds()
        {
            var r = base.GetContentBounds();

            r.Y -= WizardAeroConsts.TitleBarHeight;
            r.Height += WizardAeroConsts.TitleBarHeight;

            return r;
        }

        public override Rectangle GetHeaderTitleBounds()
        {
            var r = base.GetHeaderTitleBounds();

            r.X -= WizardAeroConsts.ContentLeftMargin - WizardAeroConsts.ContentRightMargin;
            r.Width += WizardAeroConsts.ContentLeftMargin - WizardAeroConsts.ContentRightMargin;

            return r;
        }

        public override Rectangle GetInteriorPageBounds(BaseWizardPage page)
        {
            var r = base.GetInteriorPageBounds(page);

            r.X -= WizardAeroConsts.ContentLeftMargin - WizardAeroConsts.ContentRightMargin;
            r.Width += WizardAeroConsts.ContentLeftMargin - WizardAeroConsts.ContentRightMargin;

            return r;
        }
    }
}