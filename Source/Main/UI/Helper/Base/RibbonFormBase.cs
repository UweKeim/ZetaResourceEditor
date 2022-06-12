namespace ZetaResourceEditor.UI.Helper.Base;

using ExtendedControlsLibrary.General.Base;

public partial class RibbonFormBase :
    DevExpressRibbonFormBase
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