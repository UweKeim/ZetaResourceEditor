namespace ExtendedControlsLibrary.Specialized.MessageBox;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Skinning;

public class MyMessageBoxInformation
{
    public MyMessageBoxInformation()
    {
        ButtonTexts = new Dictionary<DialogResult, string>
        {
            {DialogResult.Abort, SkinningResources.SR_Button_Abort},
            {DialogResult.Cancel, SkinningResources.SR_Button_Cancel},
            {DialogResult.Ignore, SkinningResources.SR_Button_Ignore},
            {DialogResult.No, SkinningResources.SR_Button_No},
            {DialogResult.OK, SkinningResources.SR_Button_OK},
            {DialogResult.Retry, SkinningResources.SR_Button_Retry},
            {DialogResult.Yes, SkinningResources.SR_Button_Yes},
        };
    }

    public IWin32Window Owner { get; set; }
    public string Text { get; set; }
    public string Caption { get; set; }
    public MessageBoxButtons Buttons { get; set; }
    public MessageBoxIcon Icon { get; set; }
    public MessageBoxDefaultButton DefaultButton { get; set; }

    public static readonly TimeSpan DefaultCloseCountDown = TimeSpan.FromSeconds(10);
    public static readonly TimeSpan DefaultCloseCountDownShort = TimeSpan.FromSeconds(5);

    /// <summary>
    /// Wenn dieser Wert größer als TimeSpan.Zero ist, dann wird heruntergezählt und danach
    /// der Default-Button ausgelöst.
    /// </summary>
    public TimeSpan CloseCountDown { get; set; }

    public bool VisualCloseCountDown { get; set; }

    public Dictionary<DialogResult, string> ButtonTexts { get; private set; }

    internal IWin32Window EffectiveOwner => findOwner(Owner);

    public MyMessageBoxInformation SetButtonText(
        DialogResult button,
        string text)
    {
        ButtonTexts[button] = text;
        return this; // Fluent interface.
    }

    internal static IWin32Window findOwner(IWin32Window owner)
    {
        switch (owner)
        {
            case null:
                return checkForm(Form.ActiveForm);
            case Form form:
                return checkForm(form);
            default:
            {
                var c = Control.FromHandle(owner.Handle);
                if (c == null)
                {
                    return checkForm(Form.ActiveForm);
                }
                else
                {
                    var f = c.FindForm();
                    return checkForm(f ?? Form.ActiveForm);
                }
            }
        }
    }

    private static IWin32Window checkForm(Form form)
    {
        if(form==null)
        {
            return null;
        }
        else
        {
            if (form.IsHandleCreated && form.Visible)
            {
                return form;
            }
            else
            {
                return checkForm(form.ParentForm);
            }
        }
    }
}