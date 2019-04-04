using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee) : base(coffee)
        {

        }
        public override double Price()

        {

            return base.Price() + .50d;

        }

        public override string Ingrediants()

        {

            return base.Ingrediants() + " + Milk Addedd";

        }

    }
}