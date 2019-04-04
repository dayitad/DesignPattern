using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive Scooter:" + miles.ToString());
        }
    }
}
