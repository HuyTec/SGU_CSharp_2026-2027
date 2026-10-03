namespace WinForms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        textBox1 = new TextBox();
        label2 = new Label();
        textBox2 = new TextBox();
        label3 = new Label();
        textBox3 = new TextBox();
        Cộng = new RadioButton();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(27, 20);
        label1.Name = "label1";
        label1.Size = new Size(31, 20);
        label1.TabIndex = 0;
        label1.Text = "a =";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(64, 20);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(177, 27);
        textBox1.TabIndex = 1;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(353, 23);
        label2.Name = "label2";
        label2.Size = new Size(32, 20);
        label2.TabIndex = 2;
        label2.Text = "b =";
        label2.Click += label2_Click;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(382, 20);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(177, 27);
        textBox2.TabIndex = 3;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(94, 78);
        label3.Name = "label3";
        label3.Size = new Size(56, 20);
        label3.TabIndex = 4;
        label3.Text = "Result: ";
        // 
        // textBox3
        // 
        textBox3.Location = new Point(177, 75);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(283, 27);
        textBox3.TabIndex = 5;
        // 
        // Cộng
        // 
        Cộng.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        Cộng.AutoSize = true;
        Cộng.Location = new Point(115, 127);
        Cộng.Name = "Cộng";
        Cộng.Size = new Size(65, 24);
        Cộng.TabIndex = 6;
        Cộng.TabStop = true;
        Cộng.Text = "Cộng";
        Cộng.UseVisualStyleBackColor = true;
        Cộng.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton1
        // 
        radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(212, 127);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(51, 24);
        radioButton1.TabIndex = 7;
        radioButton1.TabStop = true;
        radioButton1.Text = "Trừ";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(296, 127);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(65, 24);
        radioButton2.TabIndex = 8;
        radioButton2.TabStop = true;
        radioButton2.Text = "Nhân";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton3
        // 
        radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(382, 127);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(59, 24);
        radioButton3.TabIndex = 9;
        radioButton3.TabStop = true;
        radioButton3.Text = "Chia";
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(257, 179);
        button1.Name = "button1";
        button1.Size = new Size(88, 80);
        button1.TabIndex = 10;
        button1.Text = "Tính";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(594, 291);
        Controls.Add(button1);
        Controls.Add(radioButton3);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(Cộng);
        Controls.Add(textBox3);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Cộng trừ nhân chia Radio";
        FormClosing += Form1_FormClosing;
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private TextBox textBox2;
    private Label label3;
    private TextBox textBox3;
    private RadioButton Cộng;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private Button button1;
}
