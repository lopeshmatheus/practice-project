using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_project
{
    class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome! Please, tell what do you want to do now?");
            Console.WriteLine("1.Set a profile.");
            Console.WriteLine("2.Buy a Robot");
            var userAnswer1 = Console.ReadLine();
            
            switch (userAnswer1)
            {
                case "1":
                    Console.Clear();
                    Person.EditProfie();
                    break;
                case "2":
                    Console.Clear();
                    Storage.Buy();
                    break;
            }

        }
    }
}
