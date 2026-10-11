using WinFormsApp1._5d;

namespace TH5C
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

            Func<Form>[] forms =
            {
                () => new fmChonBai(),
                () => new fmMauListBox(),
                () => new fmMauDantoc(),
                () => new fmMauPhongBan(),
                () => new fmUocSo(),
                () => new fmSinhVien(),
                () => new fmChuoi(),
                () => new fmTuDien(),
                () => new fmListSo(),
                () => new fmDanhBa(),
                () => new formBaitap1(),
                () => new formBaitap2(),
                () => new frmLop(),
                () => new WinFormsApp1._5d.ListView(),
                () => new QLMonHoc(),
                () => new QLSinhVien(),
                () => new QuanLyDiem(),
                () => new WinFormsApp1._5d.SaveFileDialog(),
                () => new Timer_Demo()
            };

            foreach (Func<Form> createForm in forms)
            {
                using Form form = createForm();
                Application.Run(form);
            }
        }
    }
}