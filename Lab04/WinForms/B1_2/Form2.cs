namespace WinForms.B2;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
        rdoRegular.Checked = true;     // trạng thái ban đầu của nhóm Font Style
        rdoAutoColor.Checked = true;   // trạng thái ban đầu của nhóm Color
    }

    // Đọc nhóm Font Style, dựng FontStyle tương ứng rồi gán lại cho Label
    private void CapNhatKieuChu()
    {
        FontStyle kieu = FontStyle.Regular;

        if (rdoBold.Checked || rdoBoldItalic.Checked)
            kieu |= FontStyle.Bold;
        if (rdoItalic.Checked || rdoBoldItalic.Checked)
            kieu |= FontStyle.Italic;

        label4.Font = new Font(label4.Font, kieu);
    }

    // Đọc nhóm Color rồi đổi màu chữ của Label
    private void CapNhatMau()
    {
        if (rdoRed.Checked) label4.ForeColor = Color.Red;
        else if (rdoGreen.Checked) label4.ForeColor = Color.Green;
        else if (rdoBlue.Checked) label4.ForeColor = Color.Blue;
        else label4.ForeColor = SystemColors.ControlText; // AutoColor
    }

    // Dùng chung cho 4 radio ở nhóm Font Style
    private void rdoKieuChu_CheckedChanged(object sender, EventArgs e)
    {
        CapNhatKieuChu();
    }

    // Dùng chung cho 4 radio ở nhóm Color
    private void rdoMau_CheckedChanged(object sender, EventArgs e)
    {
        CapNhatMau();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();   // việc hỏi xác nhận do FormClosing xử lý
    }

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult kq = MessageBox.Show(
            "Bạn có chắc muốn thoát?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (kq == DialogResult.No)
            e.Cancel = true;
    }

}