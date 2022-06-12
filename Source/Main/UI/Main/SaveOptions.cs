namespace ZetaResourceEditor.UI.Main;

[Flags]
internal enum SaveOptions
{
    None = 0,
    AskConfirm = 0x0001,
    OnlyIfModified = 0x0002
}