namespace ZetaResourceEditor.UI.Projects;

using Helper.Base;
using Properties;
using RuntimeBusinessLogic.Projects;
using RuntimeUserInterface.Shell;
using System.IO;

public partial class CreateNewProjectForm :
    FormBase
{
    public CreateNewProjectForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Update UI states, based on the state of the current selection, etc.
    /// </summary>
    public override void UpdateUI()
    {
        base.UpdateUI();

        buttonOK.Enabled =
            !string.IsNullOrEmpty(locationTextBox.Text) &&
            Directory.Exists(locationTextBox.Text) &&
            !string.IsNullOrEmpty(nameTextBox.Text.Trim()) &&
            nameTextBox.Text.Trim().IndexOfAny(Path.GetInvalidFileNameChars()) < 0 &&
            !ProjectConfigurationFilePath.Exists;

        openButton.Enabled =
            !string.IsNullOrEmpty(locationTextBox.Text) &&
            Directory.Exists(locationTextBox.Text);
    }

    /// <summary>
    /// Gets the project configuration file path.
    /// Only valid if closed with OK.
    /// </summary>
    /// <value>The project configuration file path.</value>
    public FileInfo ProjectConfigurationFilePath => new(
        ZspPathHelper.Combine(
            locationTextBox.Text,
            nameTextBox.Text.Trim() + Project.ProjectFileExtension));

    //private void button1_Click( object sender, EventArgs e )
    //{
    //    ((Button)sender).ContextMenuStrip.Show(
    //        ((Button)sender),
    //        new Point( 0, ((Button)sender).Height ) );
    //}

    private void CreateNewProjectForm_Load(object sender, EventArgs e)
    {
        //WinFormsPersistanceHelper.RestoreState(this);
        CenterToParent();

        var defaultFolderPath =
            ZspPathHelper.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal),
                Resources.SR_CreateNewProjectForm_CreateNewProjectFormLoad_ZetaResourceEditorProjects);

        if (!Directory.Exists(defaultFolderPath))
        {
            Directory.CreateDirectory(defaultFolderPath);
        }

        locationTextBox.Text =
            PersistanceHelper.RestoreValue(
                @"NewLocation",
                defaultFolderPath) as string;

        UpdateUI();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        PersistanceHelper.SaveValue(locationTextBox.Text, @"NewLocation");
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void locationTextBox_TextChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    /// <summary>
    /// Handles the Opening event of the contextMenuStrip1 control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> 
    /// instance containing the event data.</param>
    private void contextMenuStrip1_Opening(
        object sender,
        CancelEventArgs e)
    {
        UpdateUI();
    }

    private void CreateNewProjectForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        WinFormsPersistanceHelper.SaveState(this);
    }

    private void browseButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        using var form = new FolderBrowserDialog
        {
            SelectedPath = locationTextBox.Text,
            ShowNewFolderButton = true,
            Description = Resources.SR_CreateNewProjectForm_browseToolStripMenuItemClick_TheProjectTo
        };
        //form.ShowEditBox = true;

        if (form.ShowDialog(this) == DialogResult.OK)
        {
            locationTextBox.Text = form.SelectedPath;
            UpdateUI();
        }
    }

    private void openButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        if (!string.IsNullOrEmpty(locationTextBox.Text) &&
            Directory.Exists(locationTextBox.Text))
        {
            var sei =
                new ShellExecuteInformation
                {
                    FileName = locationTextBox.Text
                };

            sei.Execute();
        }
    }
}