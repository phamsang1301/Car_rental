using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetUIv1
{
    class Rent
    {
        private enum RentState
        {
            created, pending, successed, failed, inProgress,
            expired, finished
        };

        static private int _RentID = 0;
        private DateTime _timeRent;
        private DateTime _timeExpire;
        private float _deposit;
        private int _vehicleID;
        private RentState _state;
        private float _price;
        private int _customerSSN;
        private int _customerID;
        private string _customerName;
        private int _managerSSN;
        private int _managerID;
        private string _managerName;
        // Create an empty Rent 

        public Rent()
        {
            _RentID++;
            _timeRent = DateTime.MinValue;
            _timeExpire = DateTime.MinValue;
            _deposit = 0;
            _vehicleID = 0;
            _state = 0;
            _price = 0;
            _customerName = _managerName = "unknown";
            _customerID = _managerID = _customerSSN = _managerSSN = 0;


        }
        public Rent(int vehicleID)
        {
            _RentID++;
            _timeRent = DateTime.MinValue;
            _timeExpire = DateTime.MinValue;
            _deposit = 0;
            _vehicleID = vehicleID;
            _state = 0;
            _price = 0;
            _customerName = _managerName = "unknown";
            _customerID = _managerID = _customerSSN = _managerSSN = 0;
        }
        // Create a Rentt with Rent ID, deposit and vehicle ID
        public Rent(float deposit, int vehicleID, int price)
        {
            _RentID++;
            _deposit = deposit;
            _vehicleID = vehicleID;
            _timeRent = DateTime.MinValue;
            _timeExpire = DateTime.MinValue;
            _state = 0;
            _price = price;
            _customerName = _managerName = "unknown";
            _customerID = _managerID = _customerSSN = _managerSSN = 0;
        }

        public Rent(float deposit, int vehicleID, DateTime timeRent, DateTime timeExpire, float price, string customerName, int mID, int cSSN, int cID, int mSSN)
        {
            _RentID++;
            _deposit = deposit;
            _vehicleID = vehicleID;
            _timeRent = timeRent;
            _timeExpire = timeExpire;
            _state = (RentState)0;
            _price = price;
            _customerName = customerName;
            _customerID = cID;
            _managerID = mID;
            _customerSSN = cSSN;
            _managerSSN = mSSN;
            _managerName = "unknown";
        }

        public void PrintRent()
        {

            Console.WriteLine("RentID: ", _RentID);
            Console.WriteLine("Deposit: ", _deposit);
            Console.WriteLine("VehicleID: ", _vehicleID);
            Console.WriteLine("TimeRent: ", _timeRent);
            Console.WriteLine("TimeExpired: ", _timeExpire);
            Console.WriteLine("State: ", _state);
            Console.WriteLine("Price: ", _price);
            Console.WriteLine("CustomerID: ", _customerID);
            Console.WriteLine("CustomerName: ", _customerName);
            Console.WriteLine("CustomerSSN: ", _customerSSN);
            Console.WriteLine("ManagerID: ", _managerID);
            Console.WriteLine("ManagerSSN: ", _managerSSN);
            Console.WriteLine("ManagerName: ", _managerName);
        }
    }
}
