using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    interface IVehiculo
    {
        public void Drive();
        public bool Refuel(int amt);
    }

    class Car : IVehiculo
    {
        int gasoline;
        public Car(int startingGasoline)
        {
            gasoline = startingGasoline;
        }
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("Car is Driving");
            }
        }
        public bool Refuel(int amt)
        {
            if (amt > 0)
            {
                gasoline += amt;
                return true;
            }
            return false;
        }
    }
    internal class PrgInterface
    {
        public static void Main()
        {
            
            Car car = new Car(0);

            
            Console.Write("Enter the amount of gasoline to refuel: ");
            int amount = int.Parse(Console.ReadLine());

           
            if (car.Refuel(amount))
            {
                car.Drive();
            }
            else
            {
                Console.WriteLine("Refueling failed.");
            }
        }
    }
}
