using System;

namespace NewbieRedone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        public static void ShowMainMenu()
        {
            int menuOption;
            Console.WriteLine("Welcome to the Newbie Simulator.");
            Console.WriteLine("Choose one of the below options:");
            Console.WriteLine("1 - Retirement simulator");
            Console.WriteLine("2 - Numbers Guessing game");
            Console.WriteLine("3 - Cat Distraction");
            Console.WriteLine("4 - Lotto game");
            Console.WriteLine("5 - Heating up the sauna");
            Console.WriteLine("6 - Bussen");
            Console.WriteLine("7 - Savings account");
            Console.WriteLine("8 - Temperature converter");
            Console.WriteLine("9 - Bank account");
            Console.WriteLine("10 - Animal heritage");
            Console.WriteLine("11 - The Ball");



            Console.WriteLine("Q - Quit program");

            string? inputMenu = Console.ReadLine();

            if (int.TryParse(inputMenu, out menuOption))
            {
                MenuOption(menuOption);
            }
            else if (inputMenu == "Q" || inputMenu == "q")
            {
                Console.WriteLine("Quitting program...");
                Environment.Exit(0); // This will close the console application
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-decimal number.");
                ShowMainMenu();
            }
        }

        private static void MenuOption(int menuOption)
            // I like switch-menus, maybe I should just change this to a switch system instead? Good stuff.
        {
            if (menuOption == 1)
            {
                RetirementSimulator retirementSimulator = new RetirementSimulator();
                retirementSimulator.RSStart();
                ShowMainMenu();
            }
            else if (menuOption == 2)
            {
                NumberGuess numberGuess = new NumberGuess();
                numberGuess.NGStart();
                ShowMainMenu();
            }
            else if (menuOption == 3)
            {
                CatDistraction catDistraction = new CatDistraction();
                catDistraction.CatStart();
                ShowMainMenu();
            }
            else if (menuOption == 4)
            {
                LottoBalls lottoBalls = new LottoBalls();
                lottoBalls.LottoStart();
                ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                ShowMainMenu();
            }
        }
    }
}