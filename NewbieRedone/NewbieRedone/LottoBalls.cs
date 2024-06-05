namespace NewbieRedone
{
    internal class LottoBalls
    {
        private int lottoNumber;
        private static int playersList = new playersList[7];

        public void LottoStart()
        {
            Random lottoNbr = new Random();
            lottoNumber = lottoNbr.Next(1,21);

            Console.WriteLine("Welcome! In this game you will chose seven random numbers between 1-20, then match them against the randomized Lotto-list.");
            Console.WriteLine("Good luck!");

            // here we want a for-loop, we want exact number of iterations

            LottoGame();
        }

        private void LottoGame()
        {
            for (int i = 0; i < playersList.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter number {i + 1} (between 1 and 20):");
                    string? playersInput = Console.ReadLine();

                    if (int.TryParse(playersInput, out int number))
                    {
                        if (number >= 1 && number <= 20)
                        {
                            playersList[i] = number;
                            break; // Exit the while loop and move to the next number
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 20.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid non-decimal number.");
                    }
                }
            }
            
            Console.WriteLine("You have entered the following numbers:");
            foreach (int number in playersList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

            // create an array containing ten lotto-ball values
            // use a for-loop to iterate each position in the array
            // then iterate through the array, comparing the stored numbers to the iterated number

            // if the player guess right, shout BINGO!

            // a bit harder version of this program: create a two-dimensional array for the lotto balls.
            // it should simulate a bingo-/lotto card