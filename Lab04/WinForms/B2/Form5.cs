namespace WinForms.B21
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text.Trim(), out int number) || number < 1 || number > 999)
            {
                MessageBox.Show(
                    "Vui lòng nhập một số nguyên dương từ 1 đến 999.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            tbxResult.Text = DocSo(number);
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            tbxResult.Clear();
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

        private static string DocSo(int number)
        {
            string[] digits =
            {
                "Không", "Một", "Hai", "Ba", "Bốn",
                "Năm", "Sáu", "Bảy", "Tám", "Chín"
            };

            if (number < 10)
                return digits[number];

            int hundreds = number / 100;
            int tens = number / 10 % 10;
            int units = number % 10;
            string result = string.Empty;

            if (hundreds > 0)
                result = digits[hundreds] + " trăm";

            if (tens > 1)
            {
                result += " " + digits[tens] + " mươi";
                result += DocChuSoHangDonVi(units, digits, true);
            }
            else if (tens == 1)
            {
                result += " mười";
                result += DocChuSoHangDonVi(units, digits, false);
            }
            else if (units > 0)
            {
                result += hundreds > 0 ? " lẻ " + digits[units] : digits[units];
            }

            return result.Trim();
        }

        private static string DocChuSoHangDonVi(int units, string[] digits, bool afterTwenty)
        {
            return units switch
            {
                0 => string.Empty,
                1 => afterTwenty ? " mốt" : " một",
                4 => afterTwenty ? " tư" : " bốn",
                5 => " lăm",
                _ => " " + digits[units]
            };
        }
    }
}
