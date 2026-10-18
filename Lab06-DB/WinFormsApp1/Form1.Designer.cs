namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SuspendLayout();
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 520);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng";
            ResumeLayout(false);
        }
    }
}
