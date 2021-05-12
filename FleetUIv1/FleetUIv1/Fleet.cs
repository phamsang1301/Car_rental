using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetUIv1
{
    public class Fleet
    {
        public int ID;
        private List<object> _listOfVehicle; //can contain both car and truck
        public int countVehicle;
        static private int _maxID = 1;

        public Fleet()
        {
            _listOfVehicle = new List<object>();
            this.countVehicle = 0;
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
                    if (foundCar.RentStatus && foundCar.CheckServiceBeforeRent())
                        return foundCar;
                }
                else if ((o.GetType()).Equals(typeof(Truck)))
                {
                    Truck foundTruck = (Truck)o;
                    if (foundTruck.RentStatus && foundTruck.CheckServiceBeforeRent())
                        return foundTruck;
                }
            }
            return null;
        }

        public bool AddCarIntoVehicleFleet(Car car)
        {
            bool isExist = false;
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == car.ID)
                {
                    isExist = true;
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == car.ID)
                {
                    isExist = true;
                }
            }
            if (isExist) return false;
            _listOfVehicle.Add(car);
            this.countVehicle++;
            return true;
        }
        public bool AddTruckIntoVehicleFleet(Truck truck)
        {
            bool isExist = false;
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == truck.ID)
                {
                    isExist = true;
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == truck.ID)
                {
                    isExist = true;
                }
            }
            if (isExist) return false;
            _listOfVehicle.Add(truck);
            this.countVehicle++;
            return true;
        }
        
        public bool RecordServiceForFleet(string type, string garageName, float price)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)))
                {
                    ((Car)o).Service(type, garageName, price);
                }
                else if ((o.GetType()).Equals(typeof(Truck)))
                {
                    ((Truck)o).Service(type, garageName, price);
                }
            }
            return true;
        }

        public bool PrintListOfCar()
        {
            
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)))
                {
                    ((Car)o).PrintVehicle();
                }
                else if ((o.GetType()).Equals(typeof(Truck)))
                {
                    ((Truck)o).PrintVehicle();
                }
            }
            return true;
        }

        public bool RecordServiceForVehicleId(int vehicleId, string type, string garageName, float price)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {
                    return ((Car)o).Service(type, garageName, price);
                    
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    return ((Truck)o).Service(type, garageName, price);
                    
                }
            }
            return false;
        }
        public object PrintVehicleInfo(int vehicleId)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {
                    return o;
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    return o;
                }
            }
            return null;
        }

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
        public bool DeleteVehicleInFleet(int vehicleId)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {
                    _listOfVehicle.RemoveAt(vehicleId);
                    //print success
                    return true;
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    _listOfVehicle.RemoveAt(vehicleId);
                    //print success
                    return true;
                }
            }
            return false;
        }
        public bool ModifyVehicleInFleet(int vehicleId,string brand, string plateCode, float distance, int rentCost)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {                  
                    
                    ((Car)o)._mileAge = distance;                 
                    ((Car)o).PlateCode = plateCode;
                    ((Car)o).carBrand = brand;
                    ((Car)o).rentCost = rentCost;
                    
                    //print success
                    return true;
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    ((Truck)o)._mileAge = distance;
                    ((Truck)o).PlateCode = plateCode;
                    ((Truck)o).carBrand = brand;
                    ((Truck)o).rentCost = rentCost;
                    //print success
                    return true;
                }
            }
            return false;
        }
        public List<object> LookForVehicleInFleet(string brand, int rentCostUp, int rentCostDown, string type)
        {
            List<object> findListVehicle = new List<object>();
            if (brand != "all")
            {
                foreach (object o in _listOfVehicle)
                {
                    if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).carBrand == brand)
                    {
                        findListVehicle.Add((Car)o);
                    }
                    else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).carBrand == brand)
                    {
                        findListVehicle.Add((Truck)o);
                    }
                }
            }
            else
            {
                findListVehicle = this._listOfVehicle;
            }
            List<object> findListVehicle2 = new List<object>();
            if (rentCostDown < rentCostUp && rentCostUp > 0)
            {
                foreach (object o in findListVehicle)
                {
                    if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).rentCost < rentCostUp && ((Car)o).rentCost > rentCostDown)
                    {
                        findListVehicle2.Add((Car)o);
                    }
                    else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).rentCost < rentCostUp && ((Truck)o).rentCost > rentCostDown)
                    {
                        findListVehicle2.Add((Truck)o);
                    }
                }
            }
            else
            {
                findListVehicle2 = findListVehicle;
            }
            List<object> findListVehicle3 = new List<object>();
            if (type != "all")
            {
                foreach (object o in findListVehicle2)
                {
                    if ((o.GetType()).Equals(typeof(Car)) && type == "Car")
                    {
                        findListVehicle3.Add((Car)o);
                    }
                    else if ((o.GetType()).Equals(typeof(Truck)) && type == "Truck")
                    {
                        findListVehicle3.Add((Truck)o);
                    }
                }
            }
            else
            {
                findListVehicle3 = findListVehicle2;
            }
            return findListVehicle3;
        }

        public List<Record> ViewServiceHistory(int vehicleId)
        {
            foreach (object o in _listOfVehicle)
            {
                if ((o.GetType()).Equals(typeof(Car)) && ((Car)o).ID == vehicleId)
                {
                    return ((Car)o)._history.PrintServiceHistory();
                }
                else if ((o.GetType()).Equals(typeof(Truck)) && ((Truck)o).ID == vehicleId)
                {
                    return ((Truck)o)._history.PrintServiceHistory();
                }
            }
            return null;
        } 
    }
}
