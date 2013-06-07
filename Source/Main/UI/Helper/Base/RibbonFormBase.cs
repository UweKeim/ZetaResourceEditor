namespace ZetaResourceEditor.UI.Helper.Base
{
	using System.ComponentModel;
	using DevExpress.XtraBars.Ribbon;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class RibbonFormBase :
		RibbonForm
	{
		public RibbonFormBase()
		{
			InitializeComponent();
		}

		public RibbonFormBase(
			IContainer container )
		{
			container.Add( this );

			InitializeComponent();
		}

		public virtual void InitiallyFillLists()
		{
		}

		public virtual void FillItemToControls()
		{
		}

		public virtual void FillControlsToItem()
		{
		}

		public virtual void UpdateUI()
		{
		}

		public virtual void PersistState()
		{
			WinFormsPersistanceHelper.SaveState( this );
		}

		public virtual void RestoreState()
		{
			WinFormsPersistanceHelper.RestoreState( this );
		}

		public virtual void RestoreState( int zoom )
		{
			WinFormsPersistanceHelper.RestoreState(
				this,
				new RestoreInformation
					{
						SuggestZoomPercent = zoom,
						//RespectWindowRatio = false
					});
		}
	}
}