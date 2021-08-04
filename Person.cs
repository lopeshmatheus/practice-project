using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classes_project
{
    //I created a person class so it can holds some useful info i'll use to interact with the robots
    class Person
    {
        public string name;
        public double money;
        public List<string> owning;


        public Person(string name = "default", double money =1000)
        {
            this.name = name;
            this.money = money;
        }
        public void CreatePerson()
        {
            Console.WriteLine("Hello, what is your name?");
            this.name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}, now, tell me, how much money do you have to spend?");
            string userMoney = Console.ReadLine();
            this.money = Convert.ToDouble(userMoney);
        }

        


        public void ShowMyBelongins()
        {
            Console.WriteLine($"Currently, I have: {owning}");
        }
        public void ShowMyMoney()
        {
            Console.WriteLine($"My current money is ${money}");
        }

    }
}
