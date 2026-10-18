namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly MenuStrip mainMenu = new();

        public Form1()
        {
            InitializeComponent();
            Text = "Quản lý cửa hàng";
            BuildMainMenu();
        }

        private void BuildMainMenu()
        {
            var inventoryMenu = new ToolStripMenuItem("Kho hàng");
            inventoryMenu.DropDownItems.Add("Tạo tồn kho", null, (_, _) => OpenForm(new InventoryForm()));
            inventoryMenu.DropDownItems.Add("Thêm sản phẩm mới", null, (_, _) => OpenForm(new ProductForm()));
            inventoryMenu.DropDownItems.Add("Nhập hàng", null, (_, _) => OpenForm(new ImportForm()));

            var salesMenu = new ToolStripMenuItem("Bán hàng");
            salesMenu.Click += (_, _) => OpenForm(new SalesForm());

            var exitMenu = new ToolStripMenuItem("Thoát");
            exitMenu.Click += (_, _) => Close();

            mainMenu.Items.AddRange([inventoryMenu, salesMenu, exitMenu]);
            MainMenuStrip = mainMenu;
            Controls.Add(mainMenu);
        }

        private void OpenForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            form.Dispose();
        }
    }
}
