using WinForms.B21;
namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            WinForms.B21.Form7 form7 = new WinForms.B21.Form7();
            Application.Run(form7);
        }
    }
}