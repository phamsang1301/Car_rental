using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRentalv1
{
    class Truck: Vehicle
    {

        static int VehicleCount = 0;
        public int ID;
        public string PlateCode = "";
        public float _mileAge;
        public ServiceHistory _history;
        public bool IsRented;

        public Truck(float mileAge, string plateCode)
        {
            this.ID = VehicleCount;
            this._mileAge = mileAge;
            this._history = new ServiceHistory(DateTime.Now);
            this.PlateCode = plateCode;
            VehicleCount++;
        }
        public override void Service(string type, string garage, float price)
        {
            if (type == "Full")
            {
                this._history.AddRecord(DateTime.Now, this._mileAge, type, price, garage);
            }
            else if (this._mileAge - this._history.PopRecord().MileAge < 500)
            {
                Console.WriteLine("Not time yet");
            }
            else
            {
                this._history.AddRecord(DateTime.Now, this._mileAge, type, price, garage);
            }
        }

        public float RecordDistance(int a, int b)
        {
            return this._history.GetRecord(a) - this._history.GetRecord(b);
        }

        public override string GetVehicleInfo()
        {
            string info = "";
            info += "\t\tVehicle ID :" + this.ID + "\r\n";
            info += "\t\tMileage : " + this._mileAge + "\r\n";
            _history.PrintServiceHistory();
            return info;
        }

        public float SuctractRecord(int index1, int index2)
        {
            return this._history.SuctractRecord(index1, index2);
        }
        public bool CompareLesserThanRecord(int index1, int index2)
        {
            return this._history.CompareLesserThanRecord(index1, index2);
        }
        public override bool CheckServiceBeforeRent()
        {
            var currentDate = DateTime.Now;
            var subDate = currentDate.Subtract(this._history.PopRecord().Date);
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
