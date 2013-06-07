namespace ZetaResourceEditor.UI.Helper
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System.Drawing;
	using Base;
	using DevExpress.Skins;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Draws a line.
	/// </summary>
	public partial class LineUserControl : 
		UserControlBase
	{
		#region Public methods.
		// ------------------------------------------------------------------

		public LineUserControl()
		{
			InitializeComponent();

			if(!DesignMode)
			{
				//// http://www.devexpress.com/Support/Center/KB/p/A2753.aspx
				//var currentSkin = CommonSkins.GetSkin(
				//    DevExpress.LookAndFeel.UserLookAndFeel.Default);

				//panel1.BackColor = currentSkin.TranslateColor(SystemColors.GrayText);
				panel1.BackColor = Color.Silver;
			}
		}

		// ------------------------------------------------------------------
		#endregion
}

	/////////////////////////////////////////////////////////////////////////
}