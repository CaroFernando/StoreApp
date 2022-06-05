namespace StoreApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            var frm = new StoreForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void RouteBtn_Click(object sender, EventArgs e)
        {
            var frm = new Routes();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            var frm = new Logs();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}