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
    public partial class VehicleInfoForm : Form
    {
        int id;
        //string type;
        int rentCost;
        string plateCode;
        string brand;
        float mileAge;
        string typeService;
        public Fleet f = new Fleet();
        public VehicleInfoForm(Fleet f1, int id)
        {
            this.f = f1;
            this.id = id;
            InitializeComponent();
            textBox1.Text = id.ToString();
            textBox1.Enabled = false;
            LoadInfo();
            textBox3.Enabled = false;
            this.rentCost = int.Parse(textBox4.Text);
            this.plateCode = textBox5.Text;
            this.brand = textBox2.Text;
            this.mileAge = float.Parse(textBox6.Text);
        }
        public void LoadInfo()
        {
            object o = this.f.PrintVehicleInfo(id);
            if ((o.GetType()).Equals(typeof(Car)))
            {
                textBox2.Text = ((Car)o).Brand;
                textBox3.Text = "Car";
                textBox4.Text = ((Car)o).RentCost.ToString();
                textBox5.Text = ((Car)o).PlateCode;
                textBox6.Text = ((Car)o).Mileage.ToString();
            }
            else if ((o.GetType()).Equals(typeof(Truck)))
            {
                textBox2.Text = ((Truck)o).Brand;
                textBox3.Text = "Truck";
                textBox4.Text = ((Truck)o).RentCost.ToString();
                textBox5.Text = ((Truck)o).PlateCode;
                textBox6.Text = ((Truck)o).Mileage.ToString();
            }
        }
        // save modify
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != this.brand || textBox2.Text != this.brand || textBox4.Text != this.rentCost.ToString() || textBox5.Text != this.plateCode || textBox6.Text != this.mileAge.ToString())
            {
                f.ModifyVehicleInFleet(id, textBox2.Text, textBox5.Text, float.Parse(textBox6.Text), int.Parse(textBox4.Text));
            }
        }
        //text box id
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about that?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                f.DeleteVehicleInFleet(this.id);
                this.Close();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.typeService = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.typeService = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.typeService = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.typeService = radioButton4.Text;
        }
        // service button
        private void button4_Click(object sender, EventArgs e)
        {
            string garageName = textBox8.Text;
            int price = int.Parse(textBox9.Text);
            if (f.RecordServiceForVehicleId(this.id, this.typeService, garageName, price))
            {
                MessageBox.Show("Serviced!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot serviced right now!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // view service history button
        private void button5_Click(object sender, EventArgs e)
        {
            List<Record> history = f.ViewServiceHistory(id);
            ViewServiceHistory viewHistory = new ViewServiceHistory(history);
            viewHistory.Show();
        }

        private void VehicleInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
