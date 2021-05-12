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
    public partial class ServiceForFleet : Form
    {
        string type = "Full";
        string garageName;
        int price;
        Fleet f = new Fleet();
        public ServiceForFleet(Fleet f1)
        {
            this.f = f1;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // service button
        private void button1_Click(object sender, EventArgs e)
        {
            garageName = textBox1.Text;
            price = int.Parse(textBox2.Text);
            if (f.RecordServiceForFleet(type, garageName, price))
            {
                MessageBox.Show("Success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failure", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            type = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            type = radioButton4.Text;
        }

        private void ServiceForFleet_Load(object sender, EventArgs e)
        {

        }
    }
}
