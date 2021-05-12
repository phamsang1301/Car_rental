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
    public partial class ViewAllRents : Form
    {
        public VehicleRentalManagement rootModel = new VehicleRentalManagement();

        public ViewAllRents(VehicleRentalManagement vehicleRentalManagementModel)
        {
            this.rootModel = vehicleRentalManagementModel;
            InitializeComponent();
            RentListBox.Text = rootModel.GetListOfRentInfo();
        }
        private void RentListBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
