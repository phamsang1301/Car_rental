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
    public partial class RentManagement : Form
    {
        VehicleRentalManagement rootModel = new VehicleRentalManagement();
        public RentManagement(VehicleRentalManagement vehicleRentalManagementModel)
        {
            this.rootModel = vehicleRentalManagementModel;
            InitializeComponent();
            IntroText.Font = new Font("Arial", 24, FontStyle.Bold);
        }

        private void AddRentButton_Click(object sender, EventArgs e)
        {
            BookAndRentForm bookAndRentForm = new BookAndRentForm(rootModel);
            bookAndRentForm.Show();
        }

        private void ViewAllRentButton_Click(object sender, EventArgs e)
        {
            ViewAllRents viewAllRents = new ViewAllRents(rootModel);
            viewAllRents.Show();
        }

        private void UpdateRentButton_Click(object sender, EventArgs e)
        {
            UpdateRent updateRent = new UpdateRent(rootModel);
            updateRent.Show();
        }

        private void DeleteRentButton_Click(object sender, EventArgs e)
        {
            DeleteRent deleteRent = new DeleteRent(rootModel);
            deleteRent.Show();
        }
    }
}
