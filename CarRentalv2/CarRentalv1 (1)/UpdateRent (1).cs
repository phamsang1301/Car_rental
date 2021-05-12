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
    public partial class UpdateRent : Form
    {
        VehicleRentalManagement rootModel = new VehicleRentalManagement();
        public UpdateRent(VehicleRentalManagement vehicleRentalManagementModel)
        {
            this.rootModel = vehicleRentalManagementModel;
            InitializeComponent();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            int vehicleID;
            float deposit, price;
            DateTime timeRent, timeExpire;
            string customerSSN = CustomerNameTextBox.Text;
            string customerName = CustomerNameTextBox.Text;
            int rentId = -1;
            string vehicleType = VehicleTypeTextBox.Text;
           
    
            try
            {
                rentId = int.Parse(RentIDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Option must be interger");
                return;
            }
            if (vehicleType != "Car" && vehicleType != "Truck")
            {
                MessageBox.Show("Vehicle type must be Car or Truck");
                return;
            }
            
            try
            {
                vehicleID = int.Parse(IDTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Vehicle ID must be interger");
                return;
            }
            
            try
            {
                price = float.Parse(PriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Price must be float");
                return;


            }

            try
            {
                deposit = float.Parse(DepositTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Deposit must be float");
                return;
            }

            
            try
            {
                timeRent = DateTime.Parse(RentDateTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Rent Date must be format MM/DD/YYYY");
                return;

            }
            try
            {
                timeExpire = DateTime.Parse(ExpireDateTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Expire Date must be format MM/DD/YYYY"); return;
            }



            if (!rootModel.UpdateRent(rentId,customerName, customerSSN, vehicleID, vehicleType, price, deposit, timeRent, timeExpire))
            {
                MessageBox.Show("Vehicle  doesn't existed");
            }
            else
            {
                MessageBox.Show("Rent has been successfully updated!");
            }
        }

        private void RentIntroText_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRent_Load(object sender, EventArgs e)
        {

        }
    }
}
