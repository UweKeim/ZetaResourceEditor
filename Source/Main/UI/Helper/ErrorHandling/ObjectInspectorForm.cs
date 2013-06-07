namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	using System;
	using System.Windows.Forms;
	using Base;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class ObjectInspectorForm :
		FormBase
	{
		public ObjectInspectorForm()
		{
			InitializeComponent();
		}

		public void Initialize(
			object objectToInspect )
		{
			propertyGrid.SelectedObject = objectToInspect;
		}

		private void objectInspectorForm_Load(
			object sender,
			EventArgs e )
		{
			WinFormsPersistanceHelper.RestoreState( this );
			CenterToParent();
		}

		private void objectInspectorForm_FormClosing(
			object sender,
			FormClosingEventArgs e )
		{
			WinFormsPersistanceHelper.SaveState( this );
		}
	}
}