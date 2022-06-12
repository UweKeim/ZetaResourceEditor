namespace ZetaResourceEditor.UI.Helper.ErrorHandling;

using Base;

public partial class TextBoxForm :
    FormBase
{
    private static bool _hasConsolas;
    private static bool _hasConsolasChecked;

    public TextBoxForm()
    {
        InitializeComponent();
    }

    public void Initialize(
        string text)
    {
        textMemoEdit.Text = text;
    }

    private void textBoxForm_Load(object sender, EventArgs e)
    {
        WinFormsPersistanceHelper.RestoreState(this);
        CenterToParent();

        if (!DesignMode)
        {
            if (!_hasConsolasChecked)
            {
                _hasConsolasChecked = true;

                var families = FontFamily.Families;

                foreach (var family in families)
                {
                    if (string.Compare(family.Name, @"Consolas", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        _hasConsolas = true;
                        break;
                    }
                }
            }

            if (_hasConsolas)
            {
                textMemoEdit.Font = new Font(@"Consolas", textMemoEdit.Font.Size);
            }
        }
    }

    private void textBoxForm_FormClosing(
        object sender,
        FormClosingEventArgs e)
    {
        WinFormsPersistanceHelper.SaveState(this);
    }

    private void textMemoEdit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.A)
        {
            textMemoEdit.SelectAll();
        }
    }
}