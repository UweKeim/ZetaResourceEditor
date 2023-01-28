namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomTabControl;

using System.ComponentModel;
using DevExpress.XtraTab;

public class MyHelperXtraTabPage :
    XtraTabPage
{
    public MyHelperXtraTabPage()
    {
        base.BackColor = SkinHelper.GetCurrentSkin().TranslateColor(SystemColors.Control);
    }

    #region Hide several properties from designer.

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Color BackColor { get => base.BackColor;
        set => base.BackColor = value;
    }

    #endregion
}