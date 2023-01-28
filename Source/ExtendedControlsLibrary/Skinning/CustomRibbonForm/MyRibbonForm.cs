namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomRibbonForm;

using System.ComponentModel;
using CustomForm;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

public class MyRibbonForm :
    RibbonForm
{
    public new bool DesignMode => base.DesignMode || DesignModeHelper.IsDesignMode;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new AutoScaleMode AutoScaleMode
    {
        get => AutoScaleMode.None;
        // ReSharper disable ValueParameterNotUsed
        set => base.AutoScaleMode = AutoScaleMode.None;
        // ReSharper restore ValueParameterNotUsed
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // Do this even in design mode to have valid UI.
        AutoScaleMode = AutoScaleMode.None;
        Appearance.Font = SkinHelper.StandardFont;
    }

    public event EventHandler<WantProcessDialogKeyEventArgs> WantProcessDialogKey;

    protected override bool ProcessDialogKey(Keys keyData)
    {
        var h = WantProcessDialogKey;
        if (h != null)
        {
            var args = new WantProcessDialogKeyEventArgs(keyData);
            h(this, args);

            if (args.Result.HasValue)
            {
                return args.Result.Value;
            }
        }

        // --

        //if ( keyData == (Keys.Control | Keys.Enter) )
        //{
        //    if (checkDoPressOKButton())
        //    {
        //        return true;
        //    }
        //}

        // --

        return base.ProcessDialogKey(keyData);
    }

    protected virtual void InitiallyFillLists()
    {
        // Does nothing.
    }

    protected virtual void FillItemToControls()
    {
        // Does nothing.
    }

    protected virtual void FillControlsToItem()
    {
        // Does nothing.
    }

    protected static int FindListControlIndex(
        ComboBoxEdit listControl,
        Predicate<object> finder)
    {
        var index = 0;
        foreach (var o in listControl.Properties.Items)
        {
            if (finder(o))
            {
                return index;
            }
            index++;
        }

        return -1;
    }
}