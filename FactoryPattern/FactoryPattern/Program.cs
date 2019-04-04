using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string cartype=Console.ReadLine();
            VehicleFactory factory = new MakeVehicleFactory();

            IFactory scooter = factory.GetVehicle(cartype);
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle(cartype);
            scooter.Drive(20);
            Console.ReadLine();
        }
    }
}
