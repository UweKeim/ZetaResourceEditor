using System;

namespace Web.Code;

public class NeedPerformTaskEventArgs :
    EventArgs
{
    public NeedPerformTaskEventArgs(
        PageLoadTaskPerformer taskPerformer )
    {
        TaskPerformer = taskPerformer;
    }

    public PageLoadTaskPerformer TaskPerformer { get; }

    public bool HasPerformed { get; set; }
}