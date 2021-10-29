namespace ExtendedControlsLibrary.Skinning.CustomGroup;

using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

public class MyGroupControl :
    GroupControl
{
    public MyGroupControl()
    {
        base.AppearanceCaption.Font = SkinHelper.StandardFont;
        //base.AppearanceCaption.Font = SkinHelper.LargeFont;
        base.AppearanceCaption.Options.UseFont = true;

        HasPadding = false;
    }

    [DefaultValue(false)]
    public bool HasPadding
    {
        get => Padding.Left > 0;
        set => base.Padding = value ? new Padding(12, 12, 12, 12) : new Padding(0);
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Padding Padding { get => base.Padding;
        set => base.Padding = value;
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override AppearanceObject AppearanceCaption => base.AppearanceCaption;
}