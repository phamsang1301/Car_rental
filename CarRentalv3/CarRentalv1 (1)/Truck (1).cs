using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRentalv1
{
    public class Truck: Vehicle
    {

        static int VehicleCount = 0;
        public string PlateCode = "";


        public Truck(float mileAge, string plateCode, int id)
        {
            this.ID = id;
            this.Mileage = mileAge;
            this.History = new ServiceHistory(DateTime.Now);
            this.PlateCode = plateCode;
        }
        public Truck(float mileAge, string plateCode, int id, string carBrand = null, int rentCost = 0)
        {
            this.ID = id;
            this.Mileage = mileAge;
            this.History = new ServiceHistory(DateTime.Now);
            this.PlateCode = plateCode;
            this.RentCost = rentCost;
            this.Brand = carBrand;
        }

        public override bool Service(string type, string garage, float price)
        {
            float hasGone = this.Mileage - this.History.PopRecord().MileAge;
            var currentDate = DateTime.Now;
            var subDate = currentDate.Subtract(this.History.PopRecord().Date);
            var date = subDate.Days;
            if ((date > 180) || (hasGone > 100))
            {
                this.History.AddRecord(DateTime.Now, this.Mileage, "Full", price, garage);
            }
            else if (hasGone > 50)
            {
                this.History.AddRecord(DateTime.Now, this.Mileage, type, price, garage);
            }
            else
            {
                return false;
            }
            return true;
        }

        public float RecordDistance(int a, int b)
        {
            return this.History.GetRecord(a) - this.History.GetRecord(b);
        }

        public override string GetVehicleInfo()
        {
            string info = "";
            info += "\t\tVehicle ID :" + this.ID + "\r\n";
            info += "\t\tMileage : " + this.Mileage + "\r\n";
            History.PrintServiceHistory();
            return info;
        }

        public float SuctractRecord(int index1, int index2)
        {
            return this.History.SuctractRecord(index1, index2);
        }
        public bool CompareLesserThanRecord(int index1, int index2)
        {
            return this.History.CompareLesserThanRecord(index1, index2);
        }
        public override bool CheckServiceBeforeRent()
        {
            var currentDate = DateTime.Now;
            var subDate = currentDate.Subtract(this.History.PopRecord().Date);
            var date = subDate.Days;
            if (date > 30)
            {
                this.Service("Full", "newFactory", 1000);
                Console.WriteLine("Car need to be serviced!");
            }
            return true;
        }
    }
}
