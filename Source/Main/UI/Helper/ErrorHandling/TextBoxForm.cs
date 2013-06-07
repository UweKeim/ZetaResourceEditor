namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	using System;
	using System.Drawing;
	
	using System.Windows.Forms;
	using Base;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using Zeta.EnterpriseLibrary.Windows.Common;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class TextBoxForm :
		FormBase
	{
		private static bool _hasConsolas;
		private static bool _hasConsolasChecked;

		public TextBoxForm()
		{
			InitializeComponent();
		}

		public void Initialize(
			string text )
		{
			textMemoEdit.Text = text;
		}

		private void buttonCopyTextToClipboard_Click(
			object sender,
			EventArgs e )
		{
			using ( new WaitCursor( this, WaitCursorOption.ShortSleep ) )
			{
				Clipboard.SetText( textMemoEdit.Text );
			}
		}

		private void wordWrapCheckEdit_CheckedChanged(
			object sender,
			EventArgs e )
		{
			textMemoEdit.Properties.WordWrap =
				wordWrapCheckEdit.Checked;
		}

		private void textBoxForm_Load( object sender, EventArgs e )
		{
			WinFormsPersistanceHelper.RestoreState( this );
			wordWrapCheckEdit.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue( @"TextBoxForm.Wrap", true ) );
			CenterToParent();

			if ( !DesignMode )
			{
				if ( !_hasConsolasChecked )
				{
					_hasConsolasChecked = true;

					var families = FontFamily.Families;

					foreach (var family in families)
					{
						if(string.Compare(family.Name, @"Consolas", true) == 0)
						{
							_hasConsolas = true;
							break;
						}
					}
				}

				if ( _hasConsolas )
				{
					textMemoEdit.Font = new Font( @"Consolas", textMemoEdit.Font.Size );
				}
			}

			wordWrapCheckEdit_CheckedChanged( null, null );
		}

		private void textBoxForm_FormClosing(
			object sender,
			FormClosingEventArgs e )
		{
			WinFormsPersistanceHelper.SaveState( this );
			PersistanceHelper.SaveValue( @"TextBoxForm.Wrap", wordWrapCheckEdit.Checked );
		}

		private void textMemoEdit_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.Control && e.KeyCode == Keys.A )
			{
				textMemoEdit.SelectAll();
			}
		}
	}
}