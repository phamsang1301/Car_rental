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
    public partial class BookAndRentForm : Form
    {
        VehicleRentalManagement rootModel = null; 
        public BookAndRentForm(VehicleRentalManagement vehicleRentalManagementModel)
        {
            this.rootModel = vehicleRentalManagementModel;
            InitializeComponent();
        }

        private void ListOfVehicleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            //int id = -1; 
            //try
            //{
            //    string carId = CarIDTextBox.Text;
            //    id  = int.Parse(carId);
            //    // Rent
            //    //if (!rootModel.BookAndRent(id))
            //    //{
            //    //    MessageBox.Show("Fail to rent a car\nCar has been rented or doesn't exist");
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("You has sucessfully rented a car");
            //    //}
            //}
            //catch
            //{
            //    // Id wrong format 
            //    MessageBox.Show("Id is wrong format");
            //}

            
        }

        private void RentManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void CarIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RentCarButton_Click(object sender, EventArgs e)
        {
            AddRentForm rent = new AddRentForm(this.rootModel, "Car");
            rent.Show();
                
        }

        private void RentTruckButton_Click(object sender, EventArgs e)
        {
            AddRentForm rent = new AddRentForm(this.rootModel, "Truck");
            rent.Show();
        }
    }
}
