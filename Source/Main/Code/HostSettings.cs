namespace ZetaResourceEditor.Code;

internal sealed class HostSettings
{
    private static volatile HostSettings _current;
    private static readonly object TypeLock = new();

    public static HostSettings Current
    {
        get
        {
            if (_current == null)
            {
                lock (TypeLock)
                {
                    _current ??= new();
                }
            }

            return _current;
        }
    }
}