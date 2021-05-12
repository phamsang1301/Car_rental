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
    public partial class VehicleManagementForm : Form
    {
        VehicleRentalManagement rootModel = null; 
        public VehicleManagementForm(VehicleRentalManagement vehicleRentalManagementModel)
        {
            this.rootModel = vehicleRentalManagementModel; 
            InitializeComponent();
            IntroText.Font = new Font("Arial", 24, FontStyle.Bold);
        }

        private void IntroText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void VehicleManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void BookAndRentButton_Click(object sender, EventArgs e)
        {
        }

        private void RentManagment_Click(object sender, EventArgs e)
        {
            RentManagement rentManagement = new RentManagement(rootModel);
            rentManagement.Show();
        }

        private void JsonExporterButton_Click(object sender, EventArgs e)
        {

        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {

        }

        private void FleetManagementButton_Click(object sender, EventArgs e)
        {
            FleetManagement fleetManagement = new FleetManagement(this.rootModel);
            fleetManagement.Show();
        }
    }
}
