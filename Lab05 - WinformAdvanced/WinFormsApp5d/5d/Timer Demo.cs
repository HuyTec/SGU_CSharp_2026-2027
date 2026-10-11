
using System;
using System.Windows.Forms;

namespace WinFormsApp1._5d
{
    public partial class Timer_Demo : Form
    {
        public Timer_Demo()
        {
            InitializeComponent();

            // Khởi động Timer
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Cập nhật giờ hệ thống mỗi giây
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
