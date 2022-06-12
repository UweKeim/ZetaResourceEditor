namespace ZetaResourceEditor.UI.FileGroups;

using Helper.Base;
using Helper.Progress;
using RuntimeBusinessLogic.FileGroups;
using RuntimeBusinessLogic.Projects;
using System.Linq;

public partial class MergeFileGroupForm :
    FormBase
{
    private FileGroup _fileGroup;
    private Project _project;

    public MergeFileGroupForm()
    {
        InitializeComponent();
    }

    public bool DidAnything { get; private set; }

    public override void UpdateUI()
    {
        base.UpdateUI();

        buttonOK.Enabled = filesToMergeControl.GetSelectedFileGroups().Any();
    }

    internal void Initialize(
        FileGroup fileGroup,
        Project project)
    {
        _fileGroup = fileGroup;
        _project = project;

        filesToMergeControl.Initialize(project, fileGroup);

        UpdateUI();
    }

    private void MergeFileGroupForm_Load(object sender, EventArgs e)
    {
        WinFormsPersistanceHelper.RestoreState(this);
        CenterToParent();

        fileGroupToMergeIntoTextBox.Text = _fileGroup.GetNameIntelligent(_project);
    }

    private void MergeFileGroupForm_FormClosing(
        object sender,
        FormClosingEventArgs e)
    {
        WinFormsPersistanceHelper.SaveState(this);
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
        var fileGroupsToMerge = filesToMergeControl.GetSelectedFileGroups();
        var didAnything = false;

        using (new BackgroundWorkerLongProgressGui(
                   delegate (object s, DoWorkEventArgs _)
                   {
                       try
                       {
                           var bw = (BackgroundWorker)s;

                           if (bw.CancellationPending)
                           {
                               throw new OperationCanceledException();
                           }

                           new FileGroupsMerger(_project).MergeIntoFileGroup(_fileGroup, fileGroupsToMerge, ref didAnything);
                       }
                       catch (OperationCanceledException)
                       {
                           // Ignore.
                       }
                   },
                   "Processing…",
                   BackgroundWorkerLongProgressGui.CancellationMode.Cancelable,
                   this))
        {
        }

        DidAnything = didAnything;
    }

    private void selectAllFileGroupsButton_Click(object sender, EventArgs e)
    {
        filesToMergeControl.NodesIterator.DoOperation(node => node.Checked = true);
        UpdateUI();
    }

    private void selectNoFileGroupsButton_Click(object sender, EventArgs e)
    {
        filesToMergeControl.NodesIterator.DoOperation(node => node.Checked = false);
        UpdateUI();
    }

    private void invertFileGroupsButton_Click(object sender, EventArgs e)
    {
        filesToMergeControl.NodesIterator.DoOperation(node => node.Checked = !node.Checked);
        UpdateUI();
    }

    private void filesToMergeControl_NodeChecked(object sender, EventArgs e)
    {
        UpdateUI();
    }
}