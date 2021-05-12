using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetUIv1
{
    public class Car : Vehicle
    {

        //static int VehicleCount = 0;
        public int ID;
        public string PlateCode = "";
        //protected float _mileAge;
        //protected ServiceHistory.ServiceHistory _history;
        public bool RentStatus;

        public Car(float mileAge, string plateCode, int id)
        {
            this.ID = id;
            this._mileAge = mileAge;
            this._history = new ServiceHistory(DateTime.Now);
            this.PlateCode = plateCode;
            //VehicleCount++;
        }
        public Car(float mileAge, string plateCode, int id, string carBrand = null, int rentCost=0)
        {
            this.ID = id;
            this._mileAge = mileAge;
            this._history = new ServiceHistory(DateTime.Now);
            this.PlateCode = plateCode;
            this.rentCost = rentCost;
            this.carBrand = carBrand;
            //VehicleCount++;
        }
        public override bool Service(string type, string garage, float price)
        {
            if (type == "Full")
            {
                this._history.AddRecord(DateTime.Now, this._mileAge, type, price, garage);
            }
            else if (this._mileAge - this._history.PopRecord().MileAge < 100)
            {
                return false;
            }
            else
            {
                this._history.AddRecord(DateTime.Now, this._mileAge, type, price, garage);
            }
            return true;
        }

        public float RecordDistance(int a, int b)
        {
            return this._history.GetRecord(a) - this._history.GetRecord(b);
        }

        public void PrintVehicle()
        {
            /*Console.WriteLine("\t\tVehicle ID : {0}", this.ID);
            Console.WriteLine("\t\tMileage : {0}", this._mileAge);
            _history.PrintServiceHistory();*/

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
                //return true;
            }
            return true;
        }
    }
}
