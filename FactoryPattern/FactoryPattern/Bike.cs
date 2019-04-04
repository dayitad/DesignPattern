using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Bike:IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Divre Bike:" + miles.ToString());
        }

    }
}
