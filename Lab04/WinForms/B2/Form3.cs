using System.Numerics;

namespace WinForms.B21
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox1.Text.Trim(), out long a) ||
                !long.TryParse(textBox2.Text.Trim(), out long b))
            {
                MessageBox.Show(
                    "Vui lòng nhập hai số nguyên hợp lệ cho a và b.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (a == 0 && b == 0)
            {
                MessageBox.Show(
                    "Không thể tính UCLN và BCNN khi cả a và b đều bằng 0.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            BigInteger soA = new(a);
            BigInteger soB = new(b);
            BigInteger ucln = BigInteger.GreatestCommonDivisor(soA, soB);
            BigInteger bcnn = soA == 0 || soB == 0
                ? BigInteger.Zero
                : BigInteger.Abs(soA / ucln * soB);

            textBox3.Text = ucln.ToString();
            textBox4.Text = bcnn.ToString();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
