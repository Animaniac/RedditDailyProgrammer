using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDailyProgrammer
{
    class Challenge4
    {
        public Challenge4()
        {
            Random random = new Random();
            int numberOfPasswords;
            int lengthOfPasswords;
            Console.WriteLine("This is a random password generator, how many passwords would you like to create?");
            numberOfPasswords = int.Parse(Console.ReadLine());
            Console.WriteLine("How long would you like the passwords to be?");
            lengthOfPasswords = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPasswords; i++)
            {
                var password = "";
                for (int x = lengthOfPasswords; x < lengthOfPasswords; x++)
                {
                    password += Convert.ToString((char)random.Next(33, 127));
                    Console.WriteLine(password);
                }
            }
            Console.ReadKey();
        }
    }
}
