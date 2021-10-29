namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects;

using System;

/// <summary>
/// Enabled to automatically store upon certain modifying operations
/// that should not be notified to the user because they are not
/// important enough and should be handled automatically.
/// </summary>
public class SilentProjectStoreGuard :
    IDisposable
{
    private readonly Project _project;
    private readonly bool _isModified;

    public SilentProjectStoreGuard(Project project)
    {
        _project = project;
        _isModified = project.IsModified;
    }

    ~SilentProjectStoreGuard()
    {
        doDispose();
    }

    #region Implementation of IDisposable

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        doDispose();
    }

    private void doDispose()
    {
        if (!_isModified)
        {
            _project.SilentStore();
        }
    }

    #endregion
}