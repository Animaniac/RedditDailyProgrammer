using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDailyProgrammer
{
    class Challenge1
    {
        public Challenge1()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();
            Console.WriteLine("What is your username?");
            var userName = Console.ReadLine();
            Console.WriteLine("Ok so your name is" + name + ", you are" + age + "years old and your username is" + userName + ".");
            Console.ReadKey();
        }
    }
}
