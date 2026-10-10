
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1._5d
{
    public partial class SaveFileDialog : Form
    {
        public SaveFileDialog()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog svg =
                new System.Windows.Forms.SaveFileDialog();

            // Bộ lọc định dạng file
            svg.Filter = "Text files (*.txt)|*.txt";
            svg.Title = "Lưu file văn bản";
            svg.DefaultExt = "txt";
            svg.AddExtension = true;

            // Hiển thị hộp thoại lưu file
            if (svg.ShowDialog() == DialogResult.OK)
            {
                string filename = svg.FileName;

                // Ghi đường dẫn file lên giao diện
                // (nếu có TextBox dùng để hiển thị đường dẫn)

                // Lưu nội dung RichTextBox vào file
                File.WriteAllText(filename, richTextBox1.Text);

                MessageBox.Show("Lưu file thành công!");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại mở file
            OpenFileDialog ofd = new OpenFileDialog();

            // Chỉ cho phép chọn file .txt
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.Title = "Chọn file văn bản cần mở";

            // Hiển thị hộp thoại
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file
                string filename = ofd.FileName;

                // Đọc nội dung file và hiển thị lên RichTextBox
                richTextBox1.Text = File.ReadAllText(filename);
            }
        }
    }
}
