using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalv1
{
    class Fleet
    {
        public int ID;
        private List<object> _listOfVehicle; //can contain both car and truck
        static private int _maxID = 1;

        public Fleet()
        {
            _listOfVehicle = new List<object>();
            ID = _maxID;
            _maxID++;
        }
        public object CheckRentStatus(int Id)
        {
            foreach (object o in _listOfVehicle)
            {
                // Add service record
                if ((o.GetType()).Equals(typeof(Car)))
                {
                    //isExist = true;
                    Car foundCar = (Car)o;
                    if (!foundCar.IsRented && foundCar.CheckServiceBeforeRent())
                        return foundCar;
                }
                else if ((o.GetType()).Equals(typeof(Truck)))
                {
                    Truck foundTruck = (Truck)o;
                    if (foundTruck.IsRented && foundTruck.CheckServiceBeforeRent())
                        return foundTruck;
                }
            }
            return null;
        }

        public bool AddCarIntoVehicleFleet(Car car)
        {
            bool isExist = false;
            foreach (Car i in _listOfVehicle)
            {
                if (i.ID == car.ID)
                {
                    isExist = true;
                    break;
                }
            }
            if (isExist) return false;
            _listOfVehicle.Add(car);
            Console.WriteLine("Vehicle has been added, vehicle Id is {0}", car.ID);
            return true;
        }
        public bool AddTruckIntoVehicleFleet(Truck truck)
        {
            bool isExist = false;
            foreach (Truck i in _listOfVehicle)
            {
                if (i.ID == truck.ID)
                {
                    isExist = true;
                    break;
                }
            }
            if (isExist) return false;
            _listOfVehicle.Add(truck);
            Console.WriteLine("Vehicle has been added, vehicle Id is {0}", truck.ID);
            return true;
        }

        public bool RecordServiceForFleet(string type, string garageName, float price)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)))
                {
                    Console.WriteLine("Service Car ID {0}", ((Car)o).ID);
                    ((Car)o).Service(type, garageName, price);
                }
                else if ((o.GetType()).Equals(typeof(Truck)))
                {
                    Console.WriteLine("Service Car ID {0}", ((Truck)o).ID);
                    ((Truck)o).Service(type, garageName, price);
                }
            }
            return true;
        }

        public string GetListOfVehicleInfo()
        {
            string info = "\tFleet ID: "+ this.ID  + " Has these vehicle:\r\n"; 
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)))
                {
                    info +=((Car)o).GetVehicleInfo();
                }
                else if ((o.GetType()).Equals(typeof(Truck)))
                {
                    info += ((Truck)o).GetVehicleInfo();
                }
            }
            return info;
        }

        public bool RecordServiceForVehicleId(int vehicleId, string type, string garageName, float price)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {
                    ((Car)o).Service(type, garageName, price);
                    return true;
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    ((Truck)o).Service(type, garageName, price);
                    return true;
                }
            }
            return false;
        }
        //public void PrintVehicleInfo(int vehicleId)
        //{
        //    foreach (object o in _listOfVehicle)
        //    {
        //        if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
        //        {
        //            ((Car)o).PrintVehicle();
        //        }
        //        else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
        //        {
        //            ((Truck)o).PrintVehicle();
        //        }
        //    }
        //}

        public float PerformSubtractionOperator(int vehicleId, int index1, int index2)
        {

            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {
                    return ((Car)o).SuctractRecord(index1, index2);
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    return ((Truck)o).SuctractRecord(index1, index2);
                }
            }
            Console.WriteLine("There is no carid like that in data");
            return 0;
        }

        public bool PerformSmallerOperator(int vehicleId, int index1, int index2)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {
                    return ((Car)o).CompareLesserThanRecord(index1, index2);
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    return ((Truck)o).CompareLesserThanRecord(index1, index2);
                }
            }
            Console.WriteLine("There is no carid like that in data");
            return false;
        }
    }
}