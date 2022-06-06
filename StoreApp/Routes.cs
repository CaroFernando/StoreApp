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
    public partial class Routes : Form
    {
        private Core.TruckDeliver breadTruck;
        private int breadTruckCount = 0;
        private Core.TruckDeliver vegetablesTruck;
        private int vegetablesTruckCount = 0;
        private Core.TruckDeliver sodaTruck;
        private int sodaTruckCount = 0;

        public Routes()
        {
            InitializeComponent();
            breadTruck = new Core.TruckDeliver(1, 1, 270);
            vegetablesTruck = new Core.TruckDeliver(3, 3, 95);
            sodaTruck = new Core.TruckDeliver(2, 2, 120);
            UpdateLabel();
        }

        private void BreadBtn_Click(object sender, EventArgs e)
        {
            if (RouteManager.addDelivery(breadTruck.Clone()))
            {
                this.breadTruckCount++;
                UpdateLabel();
            }
        }

        private void VegetablesBtn_Click(object sender, EventArgs e)
        {
            if (RouteManager.addDelivery(vegetablesTruck.Clone()))
            {
                this.vegetablesTruckCount++;
                UpdateLabel();
            }
        }

        private void SodaBtn_Click(object sender, EventArgs e)
        {
            if (RouteManager.addDelivery(sodaTruck.Clone()))
            {
                this.sodaTruckCount++;
                UpdateLabel();
            }
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            if (RouteManager.route.ValidateRoute())
            {
                string leftovermessage = "";
                foreach(var item in RouteManager.route.getDeliveryCapacity())
                {
                    leftovermessage += "ProductId: " + item.Key + " quantity: " + item.Value + " \n";
                }
                MessageBox.Show("Route is valid with lefovers \n" + leftovermessage);
            }
            else
            {
                MessageBox.Show("Route is not valid");
            }
        }

        private void SimulationBtn_Click(object sender, EventArgs e)
        {
            if (!RouteManager.route.Validated){
                MessageBox.Show("Route is not valid");
                return;
            } 
            
            List<Core.Store> routeOrder = RouteManager.route.GenerateRoute();
            Core.QR.QRApiAdapter qrAdapter = new Core.QR.QRApiAdapter();
            qrAdapter.adaptee = new Core.QR.QRApiCaller();
            this.Enabled = false;
            
            foreach (Core.Store store in routeOrder)
            {
                // read qr
                String qrlocation = store.Id + ".png";
                Core.Store s = qrAdapter.readQR(qrlocation);

                RouteManager.route.Deliver(s);
                MessageBox.Show("Delivered store: " + s.Name + " reading new order");

                var frm = new CreateOrder(ref s);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.ShowDialog();

                RouteManager.addStore(s);
                qrAdapter.getQR(s);

            }
            this.Enabled = true;
            RouteManager.route.resetDeliveries();
            RouteManager.route.resetCalculatedValues();
            breadTruckCount = 0;
            vegetablesTruckCount = 0;
            sodaTruckCount = 0;
            UpdateLabel();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            RouteManager.route.resetDeliveries();
            RouteManager.route.resetCalculatedValues();
            breadTruckCount = 0;
            vegetablesTruckCount = 0;
            sodaTruckCount = 0;
            UpdateLabel();
        }

        public void UpdateLabel()
        {
            Info.Text = "Bread Truck: " + breadTruckCount + " Vegetables Truck: " + vegetablesTruckCount + " Soda Truck: " + sodaTruckCount;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
