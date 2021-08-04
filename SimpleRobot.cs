using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_project
{
    class SimpleRobot : Robot
    {
        public SimpleRobot(string name, int year, double price=199.90): base (name, year, price)
        {
        }
        public void CleanHouse()
        {
            Console.WriteLine($"{Name} is cleaning the house now...");
        }
        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}, I was built in {Year} and you paid ${Price} for me! It's a pleasure.");
        }
    }

}
