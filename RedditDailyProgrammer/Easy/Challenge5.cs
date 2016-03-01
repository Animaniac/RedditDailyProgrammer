using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RedditDailyProgrammer
{
    //create a password protected program
    class Challenge5
    {
        public Challenge5()
        {
            var userName = "Rhys";
            var passWord = "password";
            bool result = false;
            StorePassword(userName, passWord);
            while (result == false)
            {
                Console.WriteLine("Hello and welcome to the program, please enter your username");
                var enteredUserName = Console.ReadLine();
                Console.WriteLine("and now your password");
                var enteredPassWord = Console.ReadLine();

                if (ValidatePassword(enteredUserName, enteredPassWord))
                    {
                        result = true;
                        Console.WriteLine("Welcome {0} enjoy", userName);
                    }
                else
                    {
                        Console.WriteLine("Your username or password was wrong");
                        
                    }
            }
        }

        bool ValidatePassword(string username, string password)
        {
            string[] content = System.IO.File.ReadAllLines(@"C:\Users\Rhys\Desktop\RedditProgarmming\RedditDailyProgrammer\Easy\Resources\Credentials.txt");

            if (username != content[0]) return false; 

            string[] saltAndHash = content[1].Split(':');

            string hash = GetHash(saltAndHash[0] + password);

            if (hash == saltAndHash[1]) return true;
            else return false;

        }

        private void StorePassword(string username, string password)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var salt = new string(
                Enumerable.Repeat(chars, 8)
                       .Select(s => s[random.Next(s.Length)])
                       .ToArray());

            string hash = GetHash(salt + password);
            string saltedHash = salt + ":" + hash;
            string[] credentials = new string[] { username, saltedHash };

            System.IO.File.WriteAllLines(@"C:\Users\Rhys\Desktop\RedditProgarmming\RedditDailyProgrammer\Easy\Resources\Credentials.txt", credentials);

        }

        string GetHash(string input)
        {
            SHA256Managed hasher = new SHA256Managed();
            byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            return BitConverter.ToString(bytes).Replace("-", "");
        }
    }
}
