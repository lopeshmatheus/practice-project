using System;
using System.Collections.Generic;

namespace classes_project
{
    class Program
    {
        static void Main(string[] args)
        {


            Robot Robot1 = new SimpleRobot("Garry", 2019);
            Robot Robot2 = new AverageRobot("Joe", 2017);
            Robot Robot3 = new CompleteRobot("Mr. Peanutbutters", 2021);

            while (true)
            {
                Login.IntroScreen();
            }



        }
      

    }
}
