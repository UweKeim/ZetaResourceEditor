namespace ZetaResourceEditor.UI.Helper.Base
{
	using System.ComponentModel;
	using DevExpress.XtraEditors;

	public partial class UserControlBase : 
		XtraUserControl
	{
		public UserControlBase()
		{
			InitializeComponent();
		}

		public UserControlBase( IContainer container )
		{
			container.Add( this );

			InitializeComponent();
		}

		public virtual void UpdateUI()
		{
		}
	}
}