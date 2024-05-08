using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbieRedone
{
    internal class NumberGuess
    {

        private int numberGuessing; // declaring this variable as a class-level field, access reasons
        public void NGStart()
        {
            Random rndNumber = new Random();
            int randomNumber = rndNumber.Next(1, 101);
            Console.WriteLine("Guess the number");

            // initiate a Method to return to so the player can guess again
            Console.WriteLine("Chose a number between 1 and 100:");
            string? inputGuess = Console.ReadLine();

            if (int.TryParse(inputGuess, out numberGuessing))
            {
                NumberGuessing(); // we don't have to declare the parameter in the brackets since we have it as a field, class-level
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-decimal number.");
            }

            // compare players guess to the randomized number and check if diff > +/-5
            // if guess == secret number ,print "You win!"
            // if else guess > secret number && diff <5 ,print "You're close, but slightly too high"
            // if else guess < secret number && diff <5 ,print "You're close, but slightly too low"
            // if else guess > secret number && diff >5 ,print "Oops, a bit too high"
            // if else guess < secret number && diff >5 ,print "Oops, a tad low"
            // else ,print "Please enter a valid number"


            // something like the above should do?

            Console.WriteLine("Press any key to return to the main menu..");
            Console.ReadKey();
        }

        private void NumberGuessing()
        {
            if (numberGuessing == 1) // correct to: if numberguess == same as randomNumber
            {
                Console.WriteLine("Placeholder code here");
                Program.ShowMainMenu();
            }
            else if (numberGuessing == 2) //  correct to: if +/- 5 etc
            {
                NumberGuess numberGuess = new NumberGuess();
                numberGuess.NGStart();
                Program.ShowMainMenu();
            }
            else // correct to: please enter a valid number etc
            {
                Console.WriteLine("Placeholder code until corrected later.");
                Console.WriteLine("Press any key.");
                Console.ReadKey();
            }
        }
    }
}