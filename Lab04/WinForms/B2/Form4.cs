using System.Numerics;

namespace WinForms.B21
{
    public partial class Form4 : Form
    {
        private readonly List<BigInteger> numbers = new();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(textBox1.Text.Trim(), out BigInteger number))
            {
                MessageBox.Show(
                    "Vui lòng nhập một số nguyên hợp lệ.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            numbers.Add(number);
            tbxArray.Text = string.Join("; ", numbers);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (!KiemTraDaySo()) return;

            tbxSum.Text = numbers.Aggregate(BigInteger.Zero, (sum, number) => sum + number).ToString();
        }

        private void btnSumEven_Click(object sender, EventArgs e)
        {
            if (!KiemTraDaySo()) return;

            tbxSumEven.Text = numbers
                .Where(number => number % 2 == 0)
                .Aggregate(BigInteger.Zero, (sum, number) => sum + number)
                .ToString();
        }

        private void btnSumOdd_Click(object sender, EventArgs e)
        {
            if (!KiemTraDaySo()) return;

            tbxSumOdd.Text = numbers
                .Where(number => number % 2 != 0)
                .Aggregate(BigInteger.Zero, (sum, number) => sum + number)
                .ToString();
        }

        private bool KiemTraDaySo()
        {
            if (numbers.Count > 0) return true;

            MessageBox.Show(
                "Vui lòng nhập ít nhất một số trước khi tính tổng.",
                "Chưa có dữ liệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            textBox1.Focus();
            return false;
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            textBox1.Clear();
            tbxArray.Clear();
            tbxSum.Clear();
            tbxSumEven.Clear();
            tbxSumOdd.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
