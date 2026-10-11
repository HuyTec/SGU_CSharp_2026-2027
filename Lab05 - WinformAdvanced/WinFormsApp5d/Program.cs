using WinFormsApp1._5d;
namespace WinFormsApp1
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

            // Mỗi form sẽ được mở sau khi form trước đó đóng lại.
            Func<Form>[] forms =
            {
                () => new WinFormsApp1._5d.formBaitap1(),
                () => new WinFormsApp1._5d.formBaitap2(),
                () => new WinFormsApp1._5d.frmLop(),
                () => new WinFormsApp1._5d.ListView(),
                () => new WinFormsApp1._5d.QLMonHoc(),
                () => new WinFormsApp1._5d.QLSinhVien(),
                () => new WinFormsApp1._5d.QuanLyDiem(),
                () => new WinFormsApp1._5d.SaveFileDialog(),
                () => new WinFormsApp1._5d.Timer_Demo()
            };

            foreach (Func<Form> createForm in forms)
            {
                using Form form = createForm();
                Application.Run(form);
            }
        }
    }
}