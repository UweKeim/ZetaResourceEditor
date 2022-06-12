namespace Test
{
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
