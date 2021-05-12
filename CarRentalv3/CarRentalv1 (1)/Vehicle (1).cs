using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalv1
{
    public abstract class Vehicle
    {
        public int ID;
        public float Mileage;
        public ServiceHistory History;
        public bool IsRented;
        public String Brand;
        public int RentCost;

        virtual public bool Service(string type, string garage, float price) { return true; }
        virtual public bool CheckServiceBeforeRent() { return false; }
        virtual public string GetVehicleInfo() { return ""; }
    }


}