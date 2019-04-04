using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public class CoffeeDecorator : ICoffee
    {
        protected ICoffee decCoffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            decCoffee = coffee;
        }
        public virtual string Ingrediants()
        {
           return decCoffee.Ingrediants();
        }

        public virtual double Price()
        {
           return decCoffee.Price();
        }
    }
}
