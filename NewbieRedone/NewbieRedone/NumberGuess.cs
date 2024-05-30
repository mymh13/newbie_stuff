using System;

namespace NewbieRedone
{
    internal class NumberGuess
    {
        private int numberGuessing; // Class-level field
        private int guessCount = 1;
        private int randomNumber;

        public void NGStart()
        {
            Random rndNumber = new Random();
            randomNumber = rndNumber.Next(1, 101);
            Console.WriteLine("Guess the number");

            GuessLoop();

            Console.WriteLine("Press any key to return to the main menu..");
            Console.ReadKey();
        }

        private void GuessLoop()
        {
            Console.WriteLine("Choose a number between 1 and 100:");
            string? inputGuess = Console.ReadLine();
            guessCount++; // this is not effectively used atm, we want this displayed in the future!
            // have a look at above line, just marking it again for reference
            // do not forget above thing. Just. Don't.

            if (int.TryParse(inputGuess, out numberGuessing))
            {
                NumberGuessing();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-decimal number.");
                GuessLoop(); // Prompt again if input is invalid
            }
        }

        private void NumberGuessing()
        {
            if (numberGuessing == randomNumber)
            {
                Console.WriteLine("You win!");
                Program.ShowMainMenu();
            }
            else if (Math.Abs(numberGuessing - randomNumber) <= 5)
            {
                if (numberGuessing > randomNumber)
                {
                    Console.WriteLine("You're close, but slightly too high.");
                }
                else
                {
                    Console.WriteLine("You're close, but slightly too low.");
                }
                GuessLoop();
            }
            else
            {
                if (numberGuessing > randomNumber)
                {
                    Console.WriteLine("Oops, a bit too high.");
                }
                else
                {
                    Console.WriteLine("Oops, a tad low.");
                }
                GuessLoop();
            }
        }
    }
}