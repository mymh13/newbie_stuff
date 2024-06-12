using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbieRedone
{
    internal class TheBus
    {
        /*
        
        public class Person // skapar klassen Person som sparar namn+ålder+kön
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
  }
  
  class Bus
	{
    List<Person> People = new List<Person>(); // skapar lista med Person
    
    public void Run()
	  {
      
		  Console.WriteLine("Let's gather some bus-riding statistics");

      int menu; // vi gör en switch-case-menu där input blir en integral
      do
      {
        Console.WriteLine("Chose what you want to do from the menu:");
        Console.WriteLine("1 - Stop the bus to add a passenger.");
        Console.WriteLine("2 - Print all details about the passengers.");
        Console.WriteLine("3 - Calculate the total age of the passengers.");
        Console.WriteLine("4 - Calculate average age of the passengers.");
        Console.WriteLine("5 - How old is the oldest passenger?");
        Console.WriteLine("6 - Look for passengers at age (or age span) X.");
        Console.WriteLine("7 - Sort bus after age.");
        Console.WriteLine("8 - Show what gender the passengers identify themselves as.");
        Console.WriteLine("9 - Poke passenger Y? (why? :)");
        Console.WriteLine("10 - Stop and let a passenger get off the bus.");
        Console.WriteLine("11 - Exit the program.");
        menu = int.Parse(Console.ReadLine());
        switch (menu)
        {
        case 1:
          AddPassenger();
          break;

        case 2:
          PrintBus();
          break;

        case 3:
          CalculateTotalAge();
          break;

        case 4:
          CalculateAverageAge();
          break;

        // case 5:
          // MaxAge();
          // break;

        // case 6:
          // SearchAge();
          // break;

        // case 7:
          // SortBus();
          // break;

        case 8:
          PrintGender();
          break;

        // case 9:
          // Poke();
          // break;

        // case 10:
          // LettingOff();
          // break;

        case 11:
          menu = 0;
          break;
        }
      } while (menu != 0);
    }

    // nr 1 på menyn
    public void AddPassenger()
	  {
      if (People.Count >=25) // testar så vi inte har 25 passagerare innan ny adderas!
        {
          Console.WriteLine("The bus is full!");
        }
      else
      {
        Console.WriteLine("What is the name, age and gender of the passenger?");
        string input = Console.ReadLine();
        // vi skapar en lista med detaljerna om varje person
        string[] personDetails = input.Split(",");

        // ger objektet Person detaljerna som sparas i 0=namn, 1=ålder, 2=kön
        Person person = new Person();
        person.Name = personDetails[0].Trim();
        person.Age = Convert.ToInt32(personDetails[1]. Trim());
        person.Gender = personDetails[2].Trim();

        People.Add(person);
      }
    }

    // nr 2 på menyn
    public void PrintBus()
    {
      People.ForEach(p => Console.WriteLine($"{p.Name}, {p.Age}, {p.Gender}"));
    }

    // nr 3 på menyn
    public void CalculateTotalAge()
    {
      // här använder vi LINQ för dess styrka att calkulera med komprimerad kod
      int totalAge = People.Sum(x => x.Age);
      // summerar Age från People i klassen Person
      Console.WriteLine($"The passengers total age is: {totalAge}");
    }

    // nr 4 på menyn
    public void CalculateAverageAge()
    {
      Console.WriteLine($"There's {People.Count} passengers with an average age of { People.Average(s => s.Age)}.");
    }

    // nr 5 på menyn
    public void MaxAge()
    {
      // int maxxAge = People.Max();
      // Console.WriteLine("Maximum Value: {0}", maxxAge);
      // int maxxAge = People.AsQueryable().Max(age => people.Age);
      // Console.WriteLine($"The age of the passenger with the maximum age is {maxxAge}");
    }

    // nr 6 på menyn
    // public void SearchAge();
    // {
      // Console.WriteLine("What age")
    // }

    // case 7:
    // public void SortBus();
    // {
      //
    // } 

    // nr 8 på menyn
    public void PrintGender()
    {
      People.ForEach(p => Console.WriteLine($"{p.Name}'s gender is {p.Gender}"));
    }

    // case 9:
    // public void Poke();
    // {
      //
    // }

    // case 10:
    // public void LettingOff();
    // {
      //
    // } 

  }

  class Program
  {
    public static void Main(string[] args)
    {
      var localbus = new Bus();
      localbus.Run();
      Console.WriteLine("Press any key to close the program.");
      Console.ReadKey();
    }

        */
    }
}
