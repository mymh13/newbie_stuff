using System;

namespace NewbieRedone
{
    internal class NumberGuess
    {
        private int numberGuessing; // Class-level field
        private int guessCount = 0;
        private int randomNumber;
        private static List<int> highscore = new List<int>();

        public void NGStart()
        {
            Random rndNumber = new Random();
            randomNumber = rndNumber.Next(1, 101);
            guessCount = 0; // resetting guess count for the new game
            Console.WriteLine("Guess the number");

            GuessLoop();

            Console.WriteLine("Press any key to return to the main menu..");
            Console.ReadKey();
        }

        private void GuessLoop()
        {
            Console.WriteLine("Choose a number between 1 and 100:");
            string? inputGuess = Console.ReadLine();
            guessCount++;

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
                Console.WriteLine("You needed " + guessCount + " guesses to solve it. Well done!");
                highscore.Add(guessCount);
                Console.WriteLine("The fewest amount of guesses is " + highscore.Min() + ". See if you can beat that?");
                Console.WriteLine("Please press any key.");
                Console.ReadKey();
                Program.ShowMainMenu();
            }
            else if (guessCount == 10)
            {
                Console.WriteLine("You have guessed wrong 10 times. Game over!");
                Console.WriteLine("Starting over:");
                NGStart();
            }
                // explaining the above: there's multiple ways to check how to end the game after 10 wrong guesses.
                // one simple way could be to have a switch-menu. Another way is to structure the code so it checks the count at the right timing.
                // in this case, we do the guessCount AFTER the guess input, so we want to make sure the users 10th guess is checked vs the right
                // answer first, but we want to check if it is 10 wrong guesses before we do the guessCount++ - which happens after guess input:
                // that position is not ideal to do an if guessCount == 10 check. So we can chose to put it here, this means the NumberGuessing method
                // checks if the guess equals the random number first, then secondary checks if guessCount is 10 before it advances to other else ifs.
                // this is not the best looking alternative (a switch menu would perhaps be?) but it solves the problem, newbie-style, which is the goal.
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