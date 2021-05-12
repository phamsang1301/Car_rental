using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalv1
{
    public abstract class Vehicle
    {
        static int VehicleCount = 0;
        public int _iD;
        protected float _mileAge;
        protected ServiceHistory _history;
        public bool IsRented;

        virtual public void Travel(float distance)
        {
            this._mileAge += distance;
        }

        virtual public void Service(string type, string garage, float price) { }
        virtual public bool CheckServiceBeforeRent() { return false; }
        virtual public string GetVehicleInfo() { return ""; }
    }


}