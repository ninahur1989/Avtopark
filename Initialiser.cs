using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark
{
    internal class Initialiser
    {
        public Vehicle[] Initialise()
        {
            Vehicle vehicle1 = new Airplane();
            Vehicle vehicle2 = new Boat();
            Vehicle vehicle3 = new FamilyCar();
            Vehicle vehicle4 = new MiddlePriceSportCar();
            Vehicle vehicle5 = new HighPriceSportCar();
            Vehicle[] vehicles = new Vehicle[] { vehicle1, vehicle2, vehicle3, vehicle4, vehicle5 };
            Array.Sort(vehicles);

            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine("i am " + vehicles[i].GetType());
                vehicles[i].CapacityCheck(vehicles[i]);
            }

            void CheckTier(ITire tire)
            {
                Console.WriteLine("i am " + tire.GetType());
                if (tire == null)
                {
                    Console.WriteLine("Error tire");
                }
                else
                {
                    Console.WriteLine(" I have some tiers");
                }
            }

            Console.WriteLine("write 'yes' if you want to check have a car tiers");
            string startQuestion = Console.ReadLine();
            if (startQuestion == "yes")
            {
                Car car = new Car();
                CheckTier(car);
            }

            return vehicles;
        }
    }
}
