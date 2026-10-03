namespace WinForms;

public partial class Form1 : Form
{
    private readonly TinhToan _tinhToan = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Cộng.Checked = true;
        textBox3.ReadOnly = true;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        Calculate();
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Calculate();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Calculate();
    }

    private void Calculate()
    {
        if (!double.TryParse(textBox1.Text, out var a) || !double.TryParse(textBox2.Text, out var b))
        {
            textBox3.Text = "Nhập số hợp lệ";
            return;
        }

        double result;

        if (Cộng.Checked)
        {
            result = _tinhToan.Add(a, b);
        }
        else if (radioButton1.Checked)
        {
            result = _tinhToan.Subtract(a, b);
        }
        else if (radioButton2.Checked)
        {
            result = _tinhToan.Multiply(a, b);
        }
        else if (radioButton3.Checked)
        {
            if (Math.Abs(b) < double.Epsilon)
            {
                textBox3.Text = "Không thể chia cho 0";
                return;
            }

            result = _tinhToan.Divide(a, b);
        }
        else
        {
            result = 0;
        }

        textBox3.Text = result.ToString();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        MessageBox.Show("Chương trình đang đóng lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
