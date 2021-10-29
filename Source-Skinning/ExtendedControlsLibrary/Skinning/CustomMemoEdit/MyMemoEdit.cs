namespace ExtendedControlsLibrary.Skinning.CustomMemoEdit;

using System.ComponentModel;
using CustomForm;
using DevExpress.XtraEditors.Controls;
using General;

public class MyMemoEdit :
    ExtendedManagedCueMemoEdit
{
    public MyMemoEdit()
    {
        if (!DesignModeHelper.IsDesignMode)
        {
            Properties.BeforeShowMenu += Properties_BeforeShowMenu;
        }
    }

    private void Properties_BeforeShowMenu(object sender, BeforeShowMenuEventArgs e)
    {
        if (_firstTime)
        {
            _firstTime = false;

            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }

    private MemoEditScrollbarAdjuster _adjuster = new MemoEditScrollbarAdjuster();
    private bool _everAttached;
    private bool _firstTime = true;

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DefaultValue(true)]
    public bool HideScrollbarsIfContentMatches
    {
        get => _adjuster != null;
        set
        {
            if (value && !_everAttached)
            {
                _adjuster.Attach(this);
                _everAttached = true;
            }

            if (value && _adjuster != null || !value && _adjuster == null)
            {
                // Do nothing.
            }
            else
            {
                if (value)
                {
                    _adjuster = new MemoEditScrollbarAdjuster();
                    _adjuster.Attach(this);
                }
                else
                {
                    _adjuster.Detach();
                    _adjuster = null;
                }
            }
        }
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFont;

        if (!DesignModeHelper.IsDesignMode)
        {
            // Self-assign to force attachment.
            HideScrollbarsIfContentMatches = HideScrollbarsIfContentMatches;
        }
    }

    protected override void OnLoaded()
    {
        base.OnLoaded();

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }

    protected override void DestroyHandle()
    {
        if (_adjuster != null)
        {
            _adjuster.Detach();
            _adjuster = null;
        }

        base.DestroyHandle();
    }
}