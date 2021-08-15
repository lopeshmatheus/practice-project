using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classes_project
{
    //I created a person class so it can holds some useful info i'll use to interact with the robots
    static class Person
    {
        static public string Name = "Default user";
        static public double Money = 1000;
        static public List<object> Owning = new List<object> { };


        static public void ShowMyBelongins()
        {
            Console.WriteLine($"Currently, I have: {Owning}");
        }
        static public void ShowMyMoney()
        {
            Console.WriteLine($"My current money is ${Money}");
        }
        static public void EditProfie()
        {
            Console.WriteLine("Welcome to you profile, please, tell me, what's your name?");
            var name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Thank you {name}, now, how much money do you have?");
            var money = Console.ReadLine();
            Console.Clear();
            var moneyDouble = Convert.ToDouble(money);
            Name = name;
            Money = moneyDouble;
            Console.Clear();
        }
    }
}
