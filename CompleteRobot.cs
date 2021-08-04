using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classes_project
{
    class CompleteRobot: AverageRobot
    {
        public CompleteRobot(string name, int year, double price= 548.54) :base(name, year, price)
        {
        }

        public void DoTheLaundry()
        {
            Console.WriteLine($"{Name} is doing the laundry...");
        }
        public void OrderMyMeal()
        {
            Console.WriteLine($"{Name} is ordering your meal...");
        }
        public void CallAnUber()
        {
            Console.WriteLine($"{Name} is calling an uber...");
        }
    }
}
