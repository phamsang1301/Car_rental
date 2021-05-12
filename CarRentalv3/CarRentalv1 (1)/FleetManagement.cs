using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalv1
{
    public partial class FleetManagement : Form
    {
        string type = "all";
        VehicleRentalManagement rootModel = null;

        public FleetManagement(VehicleRentalManagement vehicleRentalManagementModel)
        {
            this.rootModel = vehicleRentalManagementModel;
            InitializeComponent();
        }


        // add new vehicle
        private void button1_Click(object sender, EventArgs e)
        {
            
            AddVehicleForm addForm = new AddVehicleForm(rootModel);
            addForm.Show();
        }

        private void _appendVehicleInfo(string brand,string rentCostUp,int rentCostDown,Fleet f)
        {
            List<object> listVehicle = f.LookForVehicleInFleet(brand, int.Parse(rentCostUp), rentCostDown, type);

            foreach (object o in listVehicle)
            {
                ListViewItem vehicle = new ListViewItem();
                if ((o.GetType()).Equals(typeof(Car)))
                {
                    vehicle.Text = ((Car)o).ID.ToString();
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = f.ID.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Car)o).Brand });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Car)o).PlateCode });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Car)o).RentCost.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Car)o).Mileage.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Car)o).History.PopRecord().Date.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Car" });
                    listView1.Items.Add(vehicle);
                }
                else if ((o.GetType()).Equals(typeof(Truck)))
                {
                    vehicle.Text = ((Truck)o).ID.ToString();
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = f.ID.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Truck)o).Brand });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Truck)o).PlateCode });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Truck)o).RentCost.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Truck)o).Mileage.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ((Truck)o).History.PopRecord().Date.ToString() });
                    vehicle.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Truck" });
                    listView1.Items.Add(vehicle);
                }
            }

        }

        // filter
        private void button6_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            
            string brand = (string.IsNullOrWhiteSpace(textBox1.Text)) ? "all": this.textBox1.Text;
            string rentCostUp = (string.IsNullOrWhiteSpace(textBox2.Text)) ? "0" : (this.textBox2.Text);
            int rentCostDown = (string.IsNullOrWhiteSpace(textBox3.Text)) ? 0 : int.Parse(this.textBox3.Text);

            foreach (Fleet fleet in rootModel.ListOfFleet)
            {
                listView1.Items.Add("Fleet ID : " + fleet.ID);
                _appendVehicleInfo(brand, rentCostUp, rentCostDown, fleet);
            }

        }
        // close
        private void button7_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private Fleet _findFleetById(int id)
        {
            foreach (Fleet fleet in rootModel.ListOfFleet)
            {
                if (fleet.ID == id) return fleet; 
            }
            return null;
        }

        // select vehicle row to see more info
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                
            ListView select = sender as ListView;
            if (select.SelectedItems.Count > 0)
            {
                ListViewItem item = select.SelectedItems[0];


                int  fleetID = int.Parse(item.SubItems[1].Text);
                
                VehicleInfoForm modifyForm = new VehicleInfoForm(_findFleetById(fleetID), int.Parse(item.Text));
                modifyForm.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.type = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.type = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.type = radioButton3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // service for all vehicle in fleet
        private void button5_Click(object sender, EventArgs e)
        {
            ServiceForFleet serFleet = new ServiceForFleet(rootModel);
            serFleet.Show();
        }
    }
}
