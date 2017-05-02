namespace ZetaResourceEditor.UI.Main
{
    using System;

    [Flags]
    internal enum SaveOptions
    {
        None = 0,
        AskConfirm = 0x0001,
        OnlyIfModified = 0x0002
    }
}