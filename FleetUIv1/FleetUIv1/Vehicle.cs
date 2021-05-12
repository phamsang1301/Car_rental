using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetUIv1
{
    public abstract class Vehicle
    {
        //static int VehicleCount = 0;
        public int _iD;
        public float _mileAge;
        public ServiceHistory _history;
        public String carBrand;
        public int rentCost;

        virtual public void Travel(float distance)
        {
            this._mileAge += distance;
        }

        virtual public bool Service(string type, string garage, float price) { return false; }
        virtual public bool CheckServiceBeforeRent() { return false; }
    }
}
