using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_project
{
    class Shop
    {
        //a list of avaible robots in the shop I can use in this class
        public List<Robot> availableRobots
        { get; set; }


        public Shop(List<Robot> availableRobots)
        {
            this.availableRobots = availableRobots;
        }


        public void AddRobots(Robot robot)
        {
            availableRobots.Add(robot);
        }


        public void ShowRobots()
        {
            foreach(Robot item in availableRobots)
            {
                Console.WriteLine(item.Name);
            }
        }


        public void Buy(Person person)
        {


            List<int> numbers = new List<int> { 1, 2, 3 };
            List<string> robotNames = new List<string>();
            foreach (Robot robot in availableRobots)
            { 
                robotNames.Add(robot.Name);
            }

            ConsoleKeyInfo userInput = "a";


            var robotsAndNumbers = numbers.Zip(robotNames, (n, r) => new { Number = n, RobotName = r });

            Console.WriteLine("Welcome! Please, tell me, which robot do you want to buy?");
            Console.WriteLine("These are our options:\n");
            foreach (var nr in robotsAndNumbers)
            {
                Console.WriteLine($"Press {nr.Number} for {nr.RobotName}\nPress {nr.Number} for {nr.RobotName}/nPress {nr.Number} for {nr.RobotName}");
                userInput = Console.ReadKey();
            }
            switch (userInput.Key)
            {
                case ConsoleKey.A:
                    person.owning.Add("Garry");
                    person.money -= 199.99;
                    break;
                case ConsoleKey.B:
                    person.owning.Add("Joe");
                    person.money -= 299.99;
                    break;
                case ConsoleKey.C:
                    person.owning.Add("Mr. Peanutbutters");
                    person.money -= 500.00;
                    break;
            }

        }
    }
}
