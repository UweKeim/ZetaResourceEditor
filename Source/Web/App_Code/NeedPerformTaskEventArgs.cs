using System;

public class NeedPerformTaskEventArgs :
	EventArgs
{
	private readonly PageLoadTaskPerformer _taskPerformer;
	private bool _hasPerformed;

	public NeedPerformTaskEventArgs(
		PageLoadTaskPerformer taskPerformer )
	{
		_taskPerformer = taskPerformer;
	}

	public PageLoadTaskPerformer TaskPerformer
	{
		get
		{
			return _taskPerformer;
		}
	}

	public bool HasPerformed
	{
		get
		{
			return _hasPerformed;
		}
		set
		{
			_hasPerformed = value;
		}
	}
}