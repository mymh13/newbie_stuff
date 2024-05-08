
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
            Console.WriteLine("Here you can try the programs we wrote in our newbie progression.");
            Console.WriteLine("Gee, how fun it will be! Or. Well. Chose one the below options:");
            Console.WriteLine("1 - the 'Retirement simulator'");
            Console.WriteLine("2 - the 'Numbers Guessing game'");
            Console.WriteLine("3 - added later..");
            Console.WriteLine("Q - Quit program (added later..)"); // when we add this, we have to adjust the int.TryParse below!

            string? inputMenu = Console.ReadLine();

            if (int.TryParse(inputMenu, out menuOption))
            {
                MenuOption(menuOption);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-decimal number.");
            }
        }

        private static void MenuOption(int menuOption)
        {
            if (menuOption == 1)
            {
                RetirementSimulator retirementChosen = new RetirementSimulator();
                retirementChosen.RSStart();
                ShowMainMenu();
            }
            else if (menuOption == 2)
            {
                NumberGuess numberGuess = new NumberGuess();
                numberGuess.NGStart();
                ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Placeholder code until corrected later.");
                Console.WriteLine("Press any key.");
                Console.ReadKey();
            }
        }
    }
}
