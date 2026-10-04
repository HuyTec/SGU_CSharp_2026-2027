namespace WinForms.B21
{
    partial class Form1
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
            lbla = new Label();
            lblb = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblResult = new Label();
            btnPlus = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // lbla
            // 
            lbla.AutoSize = true;
            lbla.Location = new Point(50, 22);
            lbla.Name = "lbla";
            lbla.Size = new Size(31, 20);
            lbla.TabIndex = 0;
            lbla.Text = "a =";
            // 
            // lblb
            // 
            lblb.AutoSize = true;
            lblb.Location = new Point(293, 23);
            lblb.Name = "lblb";
            lblb.Size = new Size(32, 20);
            lblb.TabIndex = 1;
            lblb.Text = "b =";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(331, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 73);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(418, 27);
            textBox3.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(31, 76);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "Kết quả";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(87, 134);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 58);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(187, 134);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(64, 58);
            btnSub.TabIndex = 7;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(293, 134);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(67, 58);
            btnMul.TabIndex = 8;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(405, 134);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(65, 58);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 240);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnPlus);
            Controls.Add(lblResult);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblb);
            Controls.Add(lbla);
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbla;
        private Label lblb;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblResult;
        private Button btnPlus;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}