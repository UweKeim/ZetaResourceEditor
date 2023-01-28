namespace ZetaResourceEditor.ExtendedControlsLibrary.General.Base;

public interface IGuiEnvironment
{
    Version ApplicationBuildVersion { get; }
    DateTime ApplicationBuildDate { get; }
    string ApplicationBuildFlavour { get; }
    Icon GetIconForDialogs();
    void ShellExecute(string url);
    void NotifyAboutException(Exception x);
    string HighLevelExpandParameters(string text);
    void HideSplash();
    void ExecuteHelp();
    string GetFormattedMessagePlusHelpLink(Exception x, bool isAHrefCapable);
    void WriteTextToLogFile(string text);
}