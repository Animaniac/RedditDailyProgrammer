using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDailyProgrammer
{
    //write a program which can calculate pi to 30dp.
    class Challenge6
    {
        public Challenge6()
        {
            Console.WriteLine("This is a pi calculator, please enter the circumference of the circle");
            var circumference = long.Parse(Console.ReadLine());
            Console.WriteLine("please enter the diameter of the circle");
            var diameter = long.Parse(Console.ReadLine());
            var pi = circumference / diameter;
            Console.WriteLine(pi);
            Console.ReadKey();
        }
    }
}
