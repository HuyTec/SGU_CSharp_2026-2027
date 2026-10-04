namespace WinForms.B21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Đọc và kiểm tra a, b; trả về false nếu không hợp lệ
        private bool DocSo(out double a, out double b)
        {
            a = 0;
            b = 0;
            if (!double.TryParse(textBox1.Text, out a) ||
                !double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho a và b.");
                return false;
            }
            return true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!DocSo(out double a, out double b)) return;
            lblResult.Text = $"Result: {a + b}";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!DocSo(out double a, out double b)) return;
            lblResult.Text = $"Result: {a - b}";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!DocSo(out double a, out double b)) return;
            lblResult.Text = $"Result: {a * b}";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!DocSo(out double a, out double b)) return;
            if (b == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                return;
            }
            lblResult.Text = $"Result: {a / b}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Are you sure to quit?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow digits, control characters, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }
    }
}