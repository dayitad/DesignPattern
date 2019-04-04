using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
  public  class Coffee : ICoffee
    {
        public string Ingrediants()
        {
            return "Simple Coffee";
        }

        public double Price()
        {
            return 3.5;
        }
    }
}
