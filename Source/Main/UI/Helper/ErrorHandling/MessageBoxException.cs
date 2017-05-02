namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
    using System;
    using System.Windows.Forms;

    public class MessageBoxException :
        Exception
    {
        public MessageBoxException(
            IWin32Window parent,
            string message,
            MessageBoxIcon icon)
        {
            Parent = parent;
            Message = message;
            Icon = icon;
        }

        public IWin32Window Parent { get; }

        public override string Message { get; }

        public MessageBoxIcon Icon { get; }

        public MessageBoxButtons Buttons => MessageBoxButtons.OK;
    }
}