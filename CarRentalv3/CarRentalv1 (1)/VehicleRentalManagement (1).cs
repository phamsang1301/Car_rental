using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalv1
{
    public interface IBookAndRent
    {
        bool BookAndRent(string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit, DateTime timeRent, DateTime timeExpire);
        bool BookAndRent(string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit);
        bool BookAndRent(string customerName, string customerSSN, int vehicleId, string vehicleType);
        bool BookAndRent();
    }
    public class VehicleRentalManagement : IBookAndRent
    {

        public List<Fleet> ListOfFleet = new List<Fleet>();
        private List<Rent> _listOfRents = new List<Rent>();
        private int _count = 0;
        private static int _countRent = 0;

        public Fleet GetFleetByID(int id)
        {
            foreach (Fleet i in ListOfFleet)
            {
                if (i.ID == id) return i; 
            }
            return null; 
        }

        public VehicleRentalManagement()
        {
            this.ListOfFleet.Add(new Fleet());
            Car newCar = new Car(100, "qwewqe", Fleet.MaxVehicleID);
            Car newCar1 = new Car(112, "qwewqe", Fleet.MaxVehicleID++);
            Car newCar2 = new Car(113, "qwewqe", Fleet.MaxVehicleID++);
            this.ListOfFleet[0].AddCarIntoVehicleFleet(newCar);
            this.ListOfFleet[0].AddCarIntoVehicleFleet(newCar1);
            this.ListOfFleet[0].AddCarIntoVehicleFleet(newCar2);
            this.ListOfFleet.Add(new Fleet());
            this.ListOfFleet[1].AddCarIntoVehicleFleet(new Car(113, "qHELoe", Fleet.MaxVehicleID++));
            this.ListOfFleet.Add(new Fleet());
            
        }

        public void AddNewFleet()
        {
            ListOfFleet.Add(new Fleet());
            _count++;
        }

        private void _addNewRent(Rent rent)
        {
            _countRent++;
            _listOfRents.Add(rent);
        }

        public bool BookAndRent(string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit,DateTime timeRent, DateTime timeExpire)
        {
            if (vehicleType == "Car")
            {
                Car foundCar = null;
                foreach (Fleet i in ListOfFleet)
                {
                    if ((foundCar = (Car)(i.CheckRentStatus(vehicleId))) != null)
                    {
                        foundCar.IsRented = true;
                       _addNewRent(new Rent(customerName , customerSSN,vehicleId, vehicleType,price,deposit,timeRent,timeExpire));
                        return true;
                    }
                }
                return false;
            }
            else if (vehicleType == "Truck")
            {
                Truck foundTruck = null;
                foreach (Fleet i in ListOfFleet)
                {
                    if ((foundTruck = (Truck)(i.CheckRentStatus(vehicleId))) != null)
                    {
                        foundTruck.IsRented = true;
                        _addNewRent(new Rent(customerName, customerSSN, vehicleId, vehicleType, price, deposit,  timeRent, timeExpire));
                        return true;
                    }
                }
                return false;
            }
            return false ; 
        }

        public bool BookAndRent()
        {
            _addNewRent(new Rent());
            return true; 
        }

        public bool BookAndRent(string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit )
        {
            if (vehicleType == "Car")
            {
                Car foundCar = null;
                foreach (Fleet i in ListOfFleet)
                {
                    if ((foundCar = (Car)(i.CheckRentStatus(vehicleId))) != null)
                    {
                        foundCar.IsRented = true;
                        _addNewRent(new Rent(customerName, customerSSN, vehicleId, vehicleType, price, deposit));
                        return true;
                    }
                }
                return false;
            }
            else if (vehicleType == "Truck")
            {
                Truck foundTruck = null;
                foreach (Fleet i in ListOfFleet)
                {
                    if ((foundTruck = (Truck)(i.CheckRentStatus(vehicleId))) != null)
                    {
                        foundTruck.IsRented = true;
                        _addNewRent(new Rent(customerName, customerSSN, vehicleId, vehicleType, price, deposit));
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public bool BookAndRent(string customerName, string customerSSN, int vehicleId, string vehicleType)
        {
            if (vehicleType == "Car")
            {
                Car foundCar = null;
                foreach (Fleet i in ListOfFleet)
                {
                    if ((foundCar = (Car)(i.CheckRentStatus(vehicleId))) != null)
                    {
                        foundCar.IsRented = true;
                        _addNewRent(new Rent(customerName, customerSSN, vehicleId, vehicleType));
                        return true;
                    }
                }
                return false;
            }
            else if (vehicleType == "Truck")
            {
                Truck foundTruck = null;
                foreach (Fleet i in ListOfFleet)
                {
                    if ((foundTruck = (Truck)(i.CheckRentStatus(vehicleId))) != null)
                    {
                        foundTruck.IsRented = true;
                        _addNewRent(new Rent(customerName, customerSSN, vehicleId, vehicleType));
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public bool UpdateRent(int rentId,string customerName, string customerSSN, int vehicleId, string vehicleType, float price, float deposit, DateTime timeRent, DateTime timeExpire)
        {
            // Find a rent
            bool isExist = false; 
            foreach (Rent i in _listOfRents)
            {
                if (i.RentID == rentId)
                {
                    isExist = true;
                    if (i.VehicleID != vehicleId)
                    {
                        // Update Vehicles rent status


                    }
                    return i.UpdateRent(customerName, customerSSN, vehicleId, vehicleType, price, deposit, timeRent, timeExpire);
                }
            }
            return isExist;
        }


        public void AddNewVehicle(int fleetId, string plateCode, String type, int mileAge)
        {
            // Find fleet by fleet id 
            foreach (Fleet i in ListOfFleet)
            {
                if (i.ID == fleetId)
                {
                    // Create new vehicle 

                    // Add new vehicle into fleet 
                    if (type == "Car")
                    {
                        Car newCar = new Car(mileAge, plateCode, Fleet.MaxID);
                        i.AddCarIntoVehicleFleet(newCar);
                    }

                    break;
                }
            }

        }


        public void ServiceFleet(int fleetId, string type, string garageName, float price)
        {
            foreach (Fleet i in ListOfFleet)
            {
                if (i.ID == fleetId)
                {
                    i.RecordServiceForFleet(type, garageName, price);
                    break;
                }
            }
        }

        public void ServiceVehicle(int vehicleId, string type, string garageName, float price)
        {
            foreach (Fleet i in ListOfFleet)
            {
                i.RecordServiceForVehicleId(vehicleId, type, garageName, price);
            }
        }

        // Rent
        public bool DeleteRent(int rentId)
        {
            // Find a rent
            bool isExist = false;
            foreach (Rent i in _listOfRents)
            {
                if (i.RentID == rentId)
                {
                    isExist = true;
                    return _listOfRents.Remove(i);
                    //TODO update vehicle before remove
                }
            }
            return isExist;
        }
        public string GetListOfRentInfo()
        {
            string info = "";
            foreach (Rent i in _listOfRents)
            {
                info += i.GetRentInfo();
            }
            return info; 
        }
        public float PerformSubtractionOperator(int carID, int index1, int index2)
        {
            foreach (Fleet i in ListOfFleet)
            {
                return i.PerformSubtractionOperator(carID, index1, index2);

            }
            return -1 ;
        }
        public bool PerformSmallerOperator(int carID, int index1, int index2)
        {
            foreach (Fleet i in ListOfFleet)
            {

                return i.PerformSmallerOperator(carID, index1, index2);

            }
            return false ;
        }

    }
}