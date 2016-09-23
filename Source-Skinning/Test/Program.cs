namespace Test
{
    using System;
    using System.Windows.Forms;
    using ExtendedControlsLibrary.Skinning;

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SkinHelper.InitializeAll();

            Application.Run(new Form1());
        }
    }
}