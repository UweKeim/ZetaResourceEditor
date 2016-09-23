namespace ExtendedControlsLibrary.Specialized.MessageBox
{
    using System.Windows.Forms;

    public static class MyMessageBox
	{
		public static DialogResult Show(
			MyMessageBoxInformation information)
		{
			return MyMessageBoxImplementation.Show(information);
		}

        //public static DialogResult Show(
        //    IWin32Window owner,
        //    string text,
        //    string caption,
        //    MessageBoxButtons buttons,
        //    MessageBoxIcon icon)
        //{
        //    return Show(
        //        new MyMessageBoxInformation
        //            {
        //                Owner = owner,
        //                Text = text,
        //                Caption = caption,
        //                Buttons = buttons,
        //                Icon = icon,
        //                DefaultButton = MessageBoxDefaultButton.Button1
        //            });
        //}

        //public static DialogResult Show(
        //    IWin32Window owner,
        //    string text,
        //    string caption,
        //    MessageBoxButtons buttons,
        //    MessageBoxIcon icon,
        //    MessageBoxDefaultButton defaultButton)
        //{
        //    return Show(
        //        new MyMessageBoxInformation
        //            {
        //                Owner = owner,
        //                Text = text,
        //                Caption = caption,
        //                Buttons = buttons,
        //                Icon = icon,
        //                DefaultButton = defaultButton
        //            });
        //}
	}
}