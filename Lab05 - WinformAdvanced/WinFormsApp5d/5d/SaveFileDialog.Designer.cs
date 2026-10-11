namespace WinFormsApp1._5d
{
    partial class SaveFileDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            btnSave = new Button();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(71, 73);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(596, 293);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 50);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập đoạn text:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(598, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(69, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu file";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.Location = new Point(71, 374);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(69, 29);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Mở file";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // SaveFileDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 439);
            Controls.Add(btnOpen);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "SaveFileDialog";
            Text = "Save File Dialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Button btnOpen;
    }
}