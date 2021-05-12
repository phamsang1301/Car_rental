using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetUIv1
{
    public class Record
    {
        public DateTime Date { get; set; }
        public float MileAge { get; set; }
        public float Price { get; set; }
        public string Garage { get; set; }
        public serviceType TypeOfService;
        public enum serviceType
        {
            Full,
            Tires,
            Engine,
            Transmission
        }

        public Record(DateTime date, float mile, string type, float price, string garage)
        {
            this.Date = date;
            this.MileAge = mile;
            this.Price = price;
            this.Garage = garage;
            switch (type)
            {
                case "Full":
                    this.TypeOfService = serviceType.Full;

                    break;
                case "Tires":
                    this.TypeOfService = serviceType.Tires;
                    break;
                case "Engine":
                    this.TypeOfService = serviceType.Engine;
                    break;
                case "Transmission":
                    this.TypeOfService = serviceType.Transmission;
                    break;
                default:
                    break;
            }
        }

        public static float operator -(Record a, Record b)
        {
            return a.MileAge - b.MileAge;
        }

        public static bool operator <(Record a, Record b)
        {
            return a.MileAge < b.MileAge;
        }

        public static bool operator >(Record a, Record b)
        {
            return a.MileAge > b.MileAge;
        }

        public void PrintRecord()
        {
            Console.WriteLine("\t\t\t\tMileage: {0}", this.MileAge);
            Console.WriteLine("\t\t\t\tPrice: {0}", this.Price);
            Console.WriteLine("\t\t\t\tService type: {0}", this.TypeOfService);
            Console.WriteLine("\t\t\t\tGarage Name: {0}", this.Garage);
            Console.WriteLine("\t\t\t\tDate service: {0}", this.Date);
        }
    }
}
