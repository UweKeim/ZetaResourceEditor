namespace ZetaResourceEditor.UI.TagOperations
{
	using System;
	using System.Collections.Generic;
	using System.Windows.Forms;
	using Helper.Base;
	using Zeta.VoyagerLibrary.WinForms.Persistance;

	/// <summary>
	/// 
	/// </summary>
	public partial class AddTagForm : 
		FormBase
	{
		private readonly List<string> _distinctTagNames;

		public AddTagForm(
			List<string> distinctTagNames )
		{
			_distinctTagNames = distinctTagNames;

			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		public string TagName
		{
			get
			{
				return textBox1.Text.Trim();
			}
		}

		private void textBox1_TextChanged(
			object sender,
			EventArgs e )
		{
			UpdateUI();
		}

		public override void UpdateUI()
		{
			base.UpdateUI();

			button1.Enabled =
				textBox1.Text.Trim().Length > 0 &&
					!_distinctTagNames.Contains( textBox1.Text.Trim() );
		}

		private void AddTagForm_Load(
			object sender,
			EventArgs e )
		{
			WinFormsPersistanceHelper.RestoreState( this );
			CenterToParent();

			UpdateUI();
		}

		private void AddTagForm_FormClosing(
			object sender,
			FormClosingEventArgs e )
		{
			WinFormsPersistanceHelper.SaveState( this );
		}
	}
}