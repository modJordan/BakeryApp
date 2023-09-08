using System;
using System.Runtime.ConstrainedExecution;
using BakeryApp;
using BakeryApp.Models;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("        Welcome to Pierre's Bakery!");
      Console.WriteLine("✧･ﾟ: *✧･ﾟ:* *:･ﾟ✧*:･ﾟ✧ ✧･ﾟ: *✧･ﾟ:* *:･ﾟ✧*:･ﾟ✧");
      Console.WriteLine("           ");
      Console.WriteLine("Type (menu) to see our Menu!");
      string menuChoice = Console.ReadLine();
      if (menuChoice == "menu" || menuChoice == "Menu" || menuChoice == "MENU")
      {
        Console.WriteLine("           ");
        Console.WriteLine("           Menu");
        Console.WriteLine("   - - ┈┈∘┈˃̶༒˂̶┈∘┈┈ - -");
        Console.WriteLine("✧ Bread Loaf     $5.00");
        Console.WriteLine("✧ Pastry         $2.00");
        Console.WriteLine("           ");
        Console.WriteLine(".·:*¨༺  Daily special from 1 - 5pm ༻¨*:·.");
        Console.WriteLine("           ");
        Console.WriteLine("✧ Buy 2 bread loaves get 1 FREE");
        Console.WriteLine("✧ Buy 3 pastries get 1 FREE");
        Console.WriteLine("           ");
        Console.WriteLine("How many loaves of bread would you like?");
        int numberOfLoaves = int.Parse(Console.ReadLine());

        Console.WriteLine("How many pastries would you like?");
        int numberOfPastries = int.Parse(Console.ReadLine());

        int totalCost = Bread.CalculateCost(numberOfLoaves) + Pastry.CalculateCost(numberOfPastries);

        Console.WriteLine($"Your total cost is: ${totalCost}.00");
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }

    }
  }
}