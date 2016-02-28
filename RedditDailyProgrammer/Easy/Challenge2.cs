using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDailyProgrammer
{
    class Challenge2
    {
        public Challenge2()
        {
            Console.WriteLine("This is a force, mass and acceleration calculator! Which would you like to calculate? \n 1.Force \n 2.Mass \n 3.Acceleration");
            var calculation = int.Parse(Console.ReadLine());
            int mass;
            int force;
            int acceleration;

            switch (calculation)                 
            {        
                case 1:
                    Console.WriteLine("What is the mass of the object?");
                    mass = int.Parse(Console.ReadLine());
                    Console.WriteLine("what is the acceleration of the object?");
                    acceleration = int.Parse(Console.ReadLine());
                    force = acceleration * mass;
                    Console.WriteLine("The object has" + force + "of force");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("What is the mass of the object?");
                    force = int.Parse(Console.ReadLine());
                    Console.WriteLine("what is the acceleration of the object?");
                    acceleration = int.Parse(Console.ReadLine());
                    mass = force / acceleration;
                    Console.WriteLine("The object has a mass of" + mass);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("What is the force of the object?");
                    force = int.Parse(Console.ReadLine());
                    Console.WriteLine("what is the mass of the object?");
                    mass = int.Parse(Console.ReadLine());
                    acceleration = force/mass;
                    Console.WriteLine("The object has an acceleration of" + acceleration);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
