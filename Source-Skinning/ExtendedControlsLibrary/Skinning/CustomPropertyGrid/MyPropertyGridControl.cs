namespace ExtendedControlsLibrary.Skinning.CustomPropertyGrid;

using System.ComponentModel;
using System.Drawing;
using CustomForm;
using DevExpress.Utils;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.ViewInfo;

public class MyPropertyGridControl :
    PropertyGridControl
{
    private bool _everSetRowWidth;
    private bool _wantAlternatingRows;
    private bool _eventConnected;
    private AppearanceObject _alternatingRowStyle;
    private AppearanceObject _normalRowStyle;

    public new object SelectedObject
    {
        get => base.SelectedObject;
        set
        {
            base.SelectedObject = value;

            // Spalte 1 etwas breiter als Spalte 2.
            if (!_everSetRowWidth)
            {
                _everSetRowWidth = true;
                RowHeaderWidth = (int) (RowHeaderWidth*1.3);
            }
        }
    }

    [DefaultValue(false)]
    public bool WantAlternatingRows
    {
        get => _wantAlternatingRows;
        set
        {
            _wantAlternatingRows = value;
            checkConnectEvent();
        }
    }

    private void checkConnectEvent()
    {
        if (!_eventConnected)
        {
            _eventConnected = true;
            _alternatingRowStyle = new()
            {
                BackColor = SkinHelper.AlternatingGridRowColors
            };

            CustomDrawRowHeaderCell += MyPropertyGridControl_CustomDrawRowHeaderCell;
            CustomDrawRowValueCell += MyPropertyGridControl_CustomDrawRowValueCell;
            CustomDrawRowHeaderIndent += MyPropertyGridControl_CustomDrawRowHeaderIndent;
            CustomDrawTreeButton += MyPropertyGridControl_CustomDrawTreeButton;
        }
    }

    private void MyPropertyGridControl_CustomDrawTreeButton(object sender, CustomDrawTreeButtonEventArgs e)
    {
        applyDrawing(e);
    }

    private void MyPropertyGridControl_CustomDrawRowHeaderIndent(object sender, CustomDrawRowHeaderIndentEventArgs e)
    {
        if (applyDrawing(e))
        {
            if (e.Row.VisibleIndex%2 == 0)
            {
                foreach (IndentInfo info in e.RowIndents)
                {
                    info.Style.Combine(_alternatingRowStyle);
                }
            }
            else
            {
                foreach (IndentInfo info in e.RowIndents)
                {
                    info.Style.Combine(checkGetNormalRowStyle(e.Row));
                }
            }
        }
    }

    private void MyPropertyGridControl_CustomDrawRowHeaderCell(object sender, CustomDrawRowHeaderCellEventArgs e)
    {
        applyDrawing(e);
    }

    private void MyPropertyGridControl_CustomDrawRowValueCell(object sender, CustomDrawRowValueCellEventArgs e)
    {
        applyDrawing(e);
    }

    private bool applyDrawing(CustomDrawRowEventArgs e)
    {
        // https://www.devexpress.com/Support/Center/Question/Details/Q539013
        // http://documentation.devexpress.com/#windowsforms/clsDevExpressXtraVerticalGridRowsCategoryRowtopic

        if (WantAlternatingRows && e.Row is not CategoryRow && FocusedRow != e.Row)
        {
            e.Appearance.Combine(e.Row.VisibleIndex % 2 == 0
                ? _alternatingRowStyle
                : checkGetNormalRowStyle(e.Row));

            return true;
        }
        else
        {
            return false;
        }
    }

    private AppearanceObject checkGetNormalRowStyle(BaseRow row)
    {
        return _normalRowStyle ??= new()
        {
            BackColor =
                row.Appearance.BackColor == Color.Empty ? SystemColors.Window : row.Appearance.BackColor
        };
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Font = SkinHelper.StandardFont;

        applyFont(Appearance.ModifiedRow);
        applyFont(Appearance.DisabledRow);
        applyFont(Appearance.FocusedRow);
        applyFont(Appearance.PressedRow);
        applyFont(Appearance.HideSelectionRow);
        applyFont(Appearance.RowHeaderPanel);
        applyFont(Appearance.ReadOnlyRow);

        OptionsBehavior.ResizeRowHeaders = false;
        OptionsBehavior.ResizeHeaderPanel = false;
        //OptionsBehavior.ResizeRowValues = false;
    }

    protected override void OnLoaded()
    {
        base.OnLoaded();

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }

    private static void applyFont(AppearanceObject app)
    {
        app.Font = SkinHelper.StandardFont;
        app.Options.UseFont = true;
    }
}