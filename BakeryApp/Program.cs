using System;
using BakeryApp;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("✧･ﾟ: *✧･ﾟ:✧･ﾟ: *✧･ﾟ:* ✧･ﾟ: *:･ﾟ✧*:･ﾟ✧･ﾟ:* ✧･ﾟ: *✧･ﾟ:* ✧･ﾟ: *✧･ﾟ:* ");
      Console.WriteLine("Type (menu) to see our menu");
      string menuChoice = Console.ReadLine();
      if (menuChoice == "menu" || menuChoice == "Menu" || menuChoice == "MENU")
      {
        Console.WriteLine("Menu");
        Console.WriteLine("- - ┈┈∘┈˃̶༒˂̶┈∘┈┈ - -");
      }

    }
  }
}