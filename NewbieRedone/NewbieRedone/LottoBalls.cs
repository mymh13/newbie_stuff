using NewbieRedone;
using System;

namespace NewbieRedone
{
    internal class LottoBalls
    {
        int[] playerNumbers = new int[5];
        int[] lottoNumbers = new int[5];

        public void LottoStart()
        {
            Console.WriteLine("In this game you will enter 5 numbers.");
            Console.WriteLine("The game will then randomize 5 numbers and see how many of the numbers that match up.");
            InputLoop();
            RandomNumbers();
            CheckMatches();
            DrawPattern();
        }

        private void InputLoop()
        {
            for (int i = 0; i < playerNumbers.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Please choose number {i + 1} between 1-20:");
                    string? inputNumber = Console.ReadLine();

                    if (int.TryParse(inputNumber, out int numberGuessing) && numberGuessing >= 1 && numberGuessing <= 20)
                    {
                        if (Array.Exists(playerNumbers, number => number == numberGuessing))
                        {
                            Console.WriteLine("Duplicate number! Please enter a different number.");
                        }
                        else
                        {
                            playerNumbers[i] = numberGuessing;
                            break; // exit this loop to proceed to the next number
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid non-decimal number between 1-20.");
                    }
                }
            }

            Console.WriteLine("Your numbers are:");
            foreach (var num in playerNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private void RandomNumbers()
        {
            Random rndNumber = new Random();
            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                while (true)
                {
                    int randomNumber = rndNumber.Next(1, 21);
                    if (!Array.Exists(lottoNumbers, number => number == randomNumber))
                    {
                        lottoNumbers[i] = randomNumber;
                        break; // exit this loop to proceed to the next number
                    }
                }
            }

            Console.WriteLine("Lotto numbers are:");
            foreach (var num in lottoNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private void CheckMatches()
        {
            int matchCount = 0;
            foreach (int playerNum in playerNumbers)
            {
                if (Array.Exists(lottoNumbers, lottoNum => lottoNum == playerNum))
                {
                    matchCount++;
                }
            }

            Console.WriteLine($"You have {matchCount} matching numbers.");
        }

        private void DrawPattern()
        {
            // Roof part of the pattern
            Console.WriteLine("______________________________ ");
            // Console.WriteLine("|                              |");

            // First line of bowls with player numbers
            for (int i = 0; i < playerNumbers.Length; i++)
            {
                Console.Write("| " + playerNumbers[i].ToString("00") + " |");
            }
            // Console.WriteLine("|");
            Console.WriteLine("");


            // Separator
            Console.WriteLine("|____||____||____||____||____|");

            // Second line of bowls with lotto numbers
            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                Console.Write("| " + lottoNumbers[i].ToString("00") + " |");
            }
            // Console.WriteLine("|");
            Console.WriteLine("");

            // Bottom part of the pattern
            Console.WriteLine("|____||____||____||____||____|");

            Console.WriteLine("Please hit any key.");
            Console.ReadKey();
        }
    }
}