using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDailyProgrammer
{
    class Challenge3
    {
        public Challenge3()
        {
            string rawInput;
            int shifts;
            Encrypt newMessage = new Encrypt();            
            Console.WriteLine("This is a caesar ciper, please enter the message you want to encrypt");
            rawInput = Console.ReadLine();
            Console.WriteLine("How many characters would you like to shift?");
            shifts = int.Parse(Console.ReadLine());
            Console.WriteLine("Your encrypted message is");
            string encypted = newMessage.Encrypted(rawInput, shifts);
            Console.WriteLine(encypted);
            Console.ReadKey();
            
        }
    }
    class Encrypt
    {
        public string Encrypted(string raw, int shift)
        {
            string encryptedMessage = null;
            char[] rawCharacters;
            rawCharacters = raw.ToCharArray();
            int temp;
            for(int i = 0; i < raw.Length; i++)
            {
                temp = rawCharacters[i] + shift;
                encryptedMessage += temp;
            }
            return encryptedMessage;
        }
    }
}
