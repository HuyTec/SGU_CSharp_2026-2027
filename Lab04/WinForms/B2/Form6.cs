namespace WinForms.B21
{
    public partial class Form6 : Form
    {
        private readonly Button[] seats;
        private readonly HashSet<Button> selectedSeats = new();
        private readonly HashSet<Button> soldSeats = new();

        public Form6()
        {
            InitializeComponent();

            seats = new[]
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15
            };

            foreach (Button seat in seats)
            {
                seat.UseVisualStyleBackColor = false;
                seat.BackColor = Color.White;
                seat.Click += Seat_Click;
            }

            btnSelect.Click += btnSelect_Click;
            btnCancel.Click += btnCancel_Click;
            btnEnd.Click += btnEnd_Click;
            tbxTotal.Text = "0";
        }

        private void Seat_Click(object? sender, EventArgs e)
        {
            if (sender is not Button seat)
                return;

            if (soldSeats.Contains(seat))
            {
                MessageBox.Show(
                    $"Ghế {seat.Text} đã được bán.",
                    "Ghế đã bán",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (selectedSeats.Add(seat))
                seat.BackColor = Color.DodgerBlue;
            else
            {
                selectedSeats.Remove(seat);
                seat.BackColor = Color.White;
            }
        }

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất một ghế.",
                    "Chưa chọn ghế",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            foreach (Button seat in selectedSeats)
            {
                soldSeats.Add(seat);
                seat.BackColor = Color.Gold;
                total += GetSeatPrice(seat);
            }

            selectedSeats.Clear();
            tbxTotal.Text = total.ToString("N0");
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            foreach (Button seat in selectedSeats)
                seat.BackColor = Color.White;

            selectedSeats.Clear();
            tbxTotal.Text = "0";
        }

        private void btnEnd_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đóng form không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

        private static int GetSeatPrice(Button seat)
        {
            int seatNumber = int.Parse(seat.Text);
            return seatNumber <= 5 ? 1000 : seatNumber <= 10 ? 1500 : 2000;
        }
    }
}