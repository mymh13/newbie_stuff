using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewbieRedone
{
    internal class Sauna
    {
        /*

        Console.WriteLine("Sauna temperature - ");
    // initierar variabler //
    int cels=0;
    int fahr=0;
    decimal rndm=0;
    bool nrtest = true;
    while (nrtest) // skapar en loop för test av bra temp //
    {
      Console.WriteLine("What's the temperature in Fahrenheit right now?");
      // vi fångar upp alla non-int för att undvika exception throw //
      int value;
      while (!int.TryParse(Console.ReadLine(), out value))
      {
        Console.WriteLine("Sorry, that was not a valid number.");
        Console.WriteLine("Try with another temperature, please.");
      }
      fahr = value;
      if (value == 0)
      {
        cels = Fahr_To_Cels(rndm);
      }
      else
      {
        cels = Fahr_To_Cels(fahr); 
      }
      
      if (cels < 82)
      {
        Console.WriteLine("It's too cold still.");
      }
      else if (cels > 87)
      {
        Console.WriteLine("It's too warm.");
      }
      else if (cels > 81 || cels < 88)
      {
        Console.WriteLine("The temperature is now perfect!");
        break;
      }
    }
  Console.ReadKey();
  }
  // anropar ny metod med argumentet fahr //
  public static int Fahr_To_Cels (int fahr)
  {
    // omvandlar F till C //
    int cels = ((fahr - 32) * 5/9);
    // returnerar värdet C //
    return cels;
  }
  public static int Fahr_To_Cels (decimal rndm)
  {
    // överlagrad metod om input == 0 //
    Random rnd = new Random();
    int cels = rnd.Next(1, 999);
    Console.Write("0 is not a valid number. Let's assume it is ");
    Console.WriteLine(cels + " degrees F!");
    return cels;
  }

        */
    }
}
