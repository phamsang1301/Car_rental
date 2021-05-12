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
    public partial class AddRentForm : Form
    {
        public VehicleRentalManagement rootModel = null; 
        private string _vehicleType = ""; 

        public AddRentForm(VehicleRentalManagement vehicleRentalManagementModel,string vehicleType)
        {
            this.rootModel = vehicleRentalManagementModel;
            this._vehicleType = vehicleType; 
            InitializeComponent();
            RentIntroText.Text = "Please fill the following form\r\nOption 1: Create empty Rent with no argument\r\nOption2" +
                ": Create an Rent with Customer Name, Customer SSN,ID\r\nOpiton 3: Create an Rent with Customer Name, Customer SSN,ID,Price and Deposit\r\nElse : Create an Rent with Customer Name, Customer SSN,ID,Price, Deposit,Rent Date and Expire Date";
        }
        private void RentForm_Load(object sender, EventArgs e)
        {

        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            int vehicleID;
            float deposit, price;
            DateTime timeRent, timeExpire;
            string customerSSN = CustomerNameTextBox.Text;
            string customerName = CustomerNameTextBox.Text;
            int option = 1;
            try
            {
                option = int.Parse(OptionTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Option must be interger");
                return;
            }

            if (option == 1)
            {
                if (!rootModel.BookAndRent())
                {
                    MessageBox.Show("Vehicle has been rented or doesn't existed");
                }
                else
                {
                    MessageBox.Show("Rent has been successfully created!");
                }
                return;
            }

            try
            {
                 vehicleID = int.Parse(IDTextBox.Text);
            }
            catch{
                  MessageBox.Show("ID must be interger");
                return;
            }

            if (option == 2)
            {
                if (!rootModel.BookAndRent(customerName,customerSSN,vehicleID, _vehicleType))
                {
                    MessageBox.Show("Vehicle has been rented or doesn't existed");
                }
                else
                {
                    MessageBox.Show("Rent has been successfully created!");
                }
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


            if (option == 3)
            {
                if (!rootModel.BookAndRent(customerName, customerSSN, vehicleID, this._vehicleType, price, deposit))
                {
                    MessageBox.Show("Vehicle has been rented or doesn't existed");
                }
                else
                {
                    MessageBox.Show("Rent has been successfully created!");
                }
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
          


            if (!rootModel.BookAndRent(customerName, customerSSN, vehicleID, _vehicleType,price,deposit,timeRent,timeExpire))
            {
                MessageBox.Show("Vehicle has been rented or doesn't existed");
            }else
            {
                MessageBox.Show("Rent has been successfully created!");
            }
        }

        private void RentIntroText_Click(object sender, EventArgs e)
        {

        }
    }
}
