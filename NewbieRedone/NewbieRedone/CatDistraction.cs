using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbieRedone
{
    internal class CatDistraction
    {
        public void CatStart()
        {
            bool distraction;
            bool cat = false;

            Console.WriteLine("Are you distracted at work?");
            Console.WriteLine("1. Yes.");
            Console.WriteLine("2. Yes, by a big fluffy Siberian cat.");
            Console.WriteLine("3. No.");

            string input = Console.ReadLine();

            if (input == "1")
            {
                distraction = true;
                Console.WriteLine("Ohnoes, productivity levels critical..!!112!");
            }
            else if (input == "2")
            {
                distraction = true;
                cat = true;
                Console.WriteLine("Puuurrfect day, please go on.");
            }
            else if (input == "3")
            {
                distraction = false;
                Console.WriteLine("Good, stay away from them distracting elements.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please grab some more Java (seewhatIdidthere) and then choose 1, 2, or 3.");
                return;
            }

            Console.ReadKey();

            // sowewhat unnecessary booleans, but cat = true is such an auto-win.. ;)
        }
    }
}
