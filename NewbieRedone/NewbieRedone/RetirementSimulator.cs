using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbieRedone
{
    internal class RetirementSimulator
    {
        public void RSStart()
        {
            Console.WriteLine("Welcome to this retirement-simulator.");
            Console.WriteLine("What is your first name?");
            string? name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            // below code is the simple solution for a new programmer, but it will throw an exception if the input cannot be converted to int
            // int age = Convert.ToInt32(Console.ReadLine());
            // below is a better solution, as it will throw an exception if the input cannot be converted to int
            int age;
            string? input = Console.ReadLine();

            if (int.TryParse(input, out age))
            {
                Console.WriteLine($"Your age is: {age}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-decimal number.");
            }

            int ageDifference = (65 - age);
            if (ageDifference > 0)
            {
                Console.WriteLine("Hello " + name + ". You will enter retirement age in " + ageDifference + " years.");
                Console.WriteLine("Press any key to return to the main menu..");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("You've already hit retirement age!");
                Console.WriteLine("Enjoy your freedom. :)");
                Console.WriteLine("Press any key to return to the main menu..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}