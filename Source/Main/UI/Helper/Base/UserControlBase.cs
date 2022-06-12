namespace ZetaResourceEditor.UI.Helper.Base;

using ExtendedControlsLibrary.General.Base;

public partial class UserControlBase :
    DevExpressXtraUserControlBase
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