﻿using System;

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
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                ShowMainMenu();
            }
        }
    }
}