using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
            UpdateTable();
        }

        public void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            foreach (Core.Store s in RouteManager.route.stores)
            {
                string hasorder = "No", btntxt = "Add";
                if (s.currentOrder != null)
                {
                    hasorder = "Yes";
                    btntxt = "Change";
                }
                dataGridView1.Rows.Add(s.Id, s.Name, hasorder, btntxt, "Delete");
            }
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "") return;

            Core.Store s = new Core.Store(RouteManager.getNextId(), NameField.Text);
            RouteManager.addStore(s);
            UpdateTable();

            MessageBox.Show("Store added");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 3)
                {
                    Core.Store temp = RouteManager.route.stores[e.RowIndex];
                    var frm = new CreateOrder(ref temp);
                    RouteManager.route.stores[e.RowIndex] = temp;
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.UpdateTable(); this.Show(); };
                    frm.Show();
                    this.UpdateTable();
                    this.Hide();
                }
                else if (e.ColumnIndex == 4)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int iid = int.Parse(id);
                    RouteManager.removeStore(iid);
                    UpdateTable();
                    MessageBox.Show("Remove order");
                    
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
