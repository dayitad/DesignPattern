using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new Coffee();

            Console.WriteLine("Price: " + coffee.Price() + " Ingrediants: " + coffee.Ingrediants());

            coffee = new Milk(coffee);

            Console.WriteLine("Price: " + coffee.Price() + " Ingrediants: " + coffee.Ingrediants());

            coffee = new Whip(coffee);

            Console.WriteLine("Price: " + coffee.Price() + " Ingrediants: " + coffee.Ingrediants());
            
            Console.ReadLine();
        }
    }
}
