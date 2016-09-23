namespace ExtendedControlsLibrary.Skinning.CustomListBox
{
    using DevExpress.XtraEditors;

    public class MyCheckedListBoxControl :
        CheckedListBoxControl
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Font = SkinHelper.StandardFont;
        }
    }
}