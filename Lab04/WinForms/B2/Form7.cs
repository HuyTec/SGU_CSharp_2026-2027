using System.Globalization;

namespace WinForms.B21
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            Button[] digitButtons =
            {
                button10, button1, button2, button3, button4,
                button5, button6, button7, button8, button9
            };

            foreach (Button button in digitButtons)
                button.Click += (_, _) => ChenKyTu(button.Text);

            buttonPLUS.Click += (_, _) => ChenKyTu("+");
            buttonSUB.Click += (_, _) => ChenKyTu("-");
            buttonMUL.Click += (_, _) => ChenKyTu("*");
            buttonDIV.Click += (_, _) => ChenKyTu("/");
            buttonEXP.Click += (_, _) => ChenKyTu("^");
            buttonSQRT.Click += (_, _) => ChenKyTu("sqrt(");
            buttonOBracket.Click += (_, _) => ChenKyTu("(");
            buttonCBracket.Click += (_, _) => ChenKyTu(")");
            button12.Click += (_, _) => txtBieuThuc.Clear();
            button11.Click += btnBang_Click;
            txtBieuThuc.KeyPress += txtBieuThuc_KeyPress;
            FormClosing += Form7_FormClosing;
        }

        private TextBox txtBieuThuc => tbxTotal;

        private void ChenKyTu(string value)
        {
            int selectionStart = txtBieuThuc.SelectionStart;
            txtBieuThuc.Text = txtBieuThuc.Text.Insert(selectionStart, value);
            txtBieuThuc.SelectionStart = selectionStart + value.Length;
            txtBieuThuc.Focus();
        }

        private void btnBang_Click(object? sender, EventArgs e)
        {
            try
            {
                double result = BieuThucCalculator.Tinh(txtBieuThuc.Text);
                txtBieuThuc.Text = result.ToString("G15", CultureInfo.InvariantCulture);
                txtBieuThuc.SelectionStart = txtBieuThuc.Text.Length;
            }
            catch (DivideByZeroException exception)
            {
                HienThiLoi(exception.Message);
            }
            catch (ArithmeticException exception)
            {
                HienThiLoi(exception.Message);
            }
            catch (FormatException exception)
            {
                HienThiLoi(exception.Message);
            }
        }

        private void txtBieuThuc_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) ||
                char.IsDigit(e.KeyChar) ||
                ".+-*/^()sqrt".Contains(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void HienThiLoi(string message)
        {
            MessageBox.Show(message, "Lỗi biểu thức", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtBieuThuc.Focus();
        }

        private void Form7_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đóng máy tính không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}