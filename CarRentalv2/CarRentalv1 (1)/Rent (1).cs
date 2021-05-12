using System;
using System.Collections.Generic;

namespace CarRentalv1
{
    class Rent
    {
        static private int _maxId = 0;
        public int RentID = 0 ; 
        private DateTime _timeRent;
        private DateTime _timeExpire;
        private float _deposit;
        public int VehicleID;
        private float _price;
        private string _customerSSN;
        private string _customerName;
        private string _vehicleType;
            
        public Rent()
        {
            _maxId++;
            RentID = _maxId;
            _timeRent = DateTime.MinValue;
            _timeExpire = DateTime.MinValue;
            _deposit = 0;
            VehicleID = 0;
            _price = 0;
            _customerName = "";
            _customerSSN = "";
        }

        public Rent(string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit, DateTime timeRent, DateTime timeExpire)
        {
            _customerName = customerName;
            _customerSSN = customerSSN;
            _maxId++;
            RentID = _maxId;
            _vehicleType = vehicleType;
            _deposit = deposit;
            VehicleID = vehicleId;
            _timeRent = timeRent;
            _timeExpire = timeExpire;
            _price = price;
         

        }

        public Rent(string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit)
        {
            _customerName = customerName;
            _customerSSN = customerSSN;
            _maxId++;
            RentID = _maxId;
            _vehicleType = vehicleType;
            _deposit = deposit;
            VehicleID = vehicleId;
            _timeRent = DateTime.MinValue;
            _timeExpire = DateTime.MinValue;
            _price = price;
          
        }

        public Rent(string customerName, string customerSSN, int vehicleId, string vehicleType)
        {
            _customerName = customerName;
            _customerSSN = customerSSN;
            _maxId++;
            RentID = _maxId;
            _vehicleType = vehicleType;
            _deposit = 0;
            VehicleID = vehicleId;
            _timeRent = DateTime.MinValue;
            _timeExpire = DateTime.MinValue;
            _price = 0;
           
        }

        public bool UpdateRent(string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit, DateTime timeRent, DateTime timeExpire)
        {
            _customerName = customerName;
            _customerSSN = customerSSN;
            _vehicleType = vehicleType;
            _price = price;
            _deposit = deposit;
            VehicleID = vehicleId;
            _timeRent = timeRent;
            _timeExpire = timeExpire;
            return true; 
        }

        public string GetRentInfo()
        {
            string info = "";
            info += "RentID: " + _maxId + "\r\n";
            info += "VehicleID: " + VehicleID + "\r\n";
            info += "CustomerName: " + _customerName + "\r\n";
            info += "CustomerSSN: " + _customerSSN + "\r\n";
            info += "Price: " + _price + "\r\n";
            info += "Deposit: " + _deposit + "\r\n";
            info += "TimeRent: " + _timeRent + "\r\n";
            info += "TimeExpired: " + _timeExpire + "\r\n";
            return info; 
        }
    }
}