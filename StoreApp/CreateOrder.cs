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
    public partial class CreateOrder : Form
    {
        private Core.Order o;
        private Core.Store s;
        
        public CreateOrder(ref Core.Store s)
        {
            this.s = s;
            InitializeComponent();
            if (s.currentOrder != null) o = s.currentOrder;
            else o = new Core.Order(RouteManager.getNextOrderId(), s.Id);
            OrderTable.AllowUserToAddRows = false;
            UpdateTable();
        }

        public void UpdateTable()
        {
            OrderTable.Rows.Clear();
            foreach (Core.Product p in o.products)
            {
                OrderTable.Rows.Add(p.id, p.name, p.quantity, p.price, p.getTotalPrice(), "Remove");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QuantityTxt.Text == "") return;

            int quantity = int.Parse(QuantityTxt.Text);
            if (BreadRadio.Checked)
            {
                o.addProduct(new Core.Product(1, "Bread", 1.5f, quantity));
            }
            else if (SodaRadio.Checked)
            {
                o.addProduct(new Core.Product(2, "Soda", 1.5f, quantity));
            }
            else if (VegetablesRadio.Checked)
            {
                o.addProduct(new Core.Product(3, "Vegetables", 1.5f, quantity));
            }
            UpdateTable();
        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.QR.QRApiAdapter qrAdapter = new Core.QR.QRApiAdapter();
            qrAdapter.adaptee = new Core.QR.QRApiCaller();
            
            this.s.SetOrder(o);
            qrAdapter.getQR(this.s);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5)
                {
                    o.products.RemoveAt(e.RowIndex);

                }
            }

            UpdateTable();
        }

        
    }
}
