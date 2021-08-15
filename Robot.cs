using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_project
{
    class Robot
    {
        static public List<Robot> AvailableRobots = new List<Robot> { };
      
        public string Name;
        public int Year;
        public double Price;
        public int Counter;
        
        public int GetIndex()
        {
            return AvailableRobots.IndexOf(this);
        }
        public Robot(string 
            name, int year, double price)
        {
            Name = name;
            Year = year;
            Price = price;
            AvailableRobots.Add(this);
            Counter += AvailableRobots.Count;

        }

        
    }
}
