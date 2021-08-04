using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_project
{
    class AverageRobot : SimpleRobot
    {

        public AverageRobot(string name, int year, double price = 299.99) : base(name, year, price)
        {

        }
       
        public void MakeCoffee()
        {
            Console.WriteLine($"{Name} is making coffee...");
        }
        public void DoTheDishes()
        {
            Console.WriteLine($"{Name} is doing the dishes...");
        }

    }
}
