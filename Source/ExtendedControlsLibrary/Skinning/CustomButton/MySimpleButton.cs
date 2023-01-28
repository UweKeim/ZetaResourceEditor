namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton;

using System.ComponentModel;
using DevExpress.XtraEditors;

[Designer(@"System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class MySimpleButton :
    SimpleButton
{
    //protected override BaseStyleControlViewInfo CreateViewInfo()
    //{
    //    if (DesignMode || IsDesignMode)
    //    {
    //        return base.CreateViewInfo();
    //    }
    //    else
    //    {
    //        return new MySimpleButtonViewInfo(this);
    //    }
    //}

    //protected override BaseControlPainter CreatePainter()
    //{
    //    if (DesignMode || IsDesignMode)
    //    {
    //        return base.CreatePainter();
    //    }
    //    else
    //    {
    //        return new MySimpleButtonPainter(this);
    //    }
    //}
    public bool WantDrawFocusRectangle { get; set; }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        WantDrawFocusRectangle = true;
        Appearance.Font = SkinHelper.StandardFont/*SemiBold*/;
    }
}

//public class MySimpleButtonPainter :
//    BaseButtonPainter
//{
//    private readonly MySimpleButton _owner;

//    public MySimpleButtonPainter(MySimpleButton owner)
//    {
//        _owner = owner;
//    }

//    protected override void DrawFocusRect(ControlGraphicsInfoArgs info)
//    {
//        //base.DrawFocusRect(info);
//    }
//}