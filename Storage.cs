using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_project
{
    static class Storage
    {
       
        static public void Buy()
        {
            Console.WriteLine("Welcome, what do you want to buy?\n");
            
            foreach (Robot robot in Robot.AvailableRobots)
            {
                Console.WriteLine($"{robot.GetIndex() +1}.{robot.Name} was built in {robot.Year} and it costs {robot.Price}");
            }
            Console.WriteLine("Please, press the key according to the robot you want to buy.");
            string userInput = Console.ReadLine();
            var userInputInt = Convert.ToInt32(userInput);

            foreach(Robot robot in Robot.AvailableRobots)
            {
                if (userInputInt == robot.GetIndex()+1)
                {
                    Console.Clear();
                    Console.WriteLine($"You've chosen {robot.Name}! Congrats!");
                    Person.Owning.Add(robot);
                    Person.Money -= robot.Price;
                    Console.WriteLine($"You now have ${Person.Money}\n");
                    Console.WriteLine("Do you want to buy more robots or return to the main menu?");
                    Console.WriteLine("Press 1 for buying more and 2 for main menu\n");
                    var userInput2 = Console.ReadLine();
                    int userInput2Int = Convert.ToInt32(userInput2);
                    switch (userInput2Int)
                    {
                        case 1:
                            Console.Clear();
                            Storage.Buy();
                            break;
                        case 2:
                            Console.Clear();
                            Menu.MainMenu();
                            break;
                    }
                }
                
            }


        }
        

    }


}

