namespace ZetaResourceEditor.Code
{
    internal sealed class HostSettings
    {
        private static volatile HostSettings _current;
        private static readonly object TypeLock = new object();

        public static HostSettings Current
        {
            get
            {
                if (_current == null)
                {
                    lock (TypeLock)
                    {
                        if (_current == null)
                        {
                            _current = new HostSettings();
                        }
                    }
                }

                return _current;
            }
        }
    }
}