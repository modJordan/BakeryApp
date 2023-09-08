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
      Console.WriteLine("        𝓦𝓮𝓵𝓬𝓸𝓶𝓮 𝓽𝓸 𝓟𝓲𝓮𝓻𝓻𝓮'𝓼 𝓑𝓪𝓴𝓮𝓻𝔂!");
      Console.WriteLine("✧･ﾟ: *✧･ﾟ:* *:･ﾟ✧*:･ﾟ✧ ✧･ﾟ: *✧･ﾟ:* *:･ﾟ✧*:･ﾟ✧");
      Console.WriteLine("           ");
      Console.WriteLine("Type (menu) to see our Menu!");
      string menuChoice = Console.ReadLine();
      if (menuChoice == "menu" || menuChoice == "Menu" || menuChoice == "MENU")
      {
        Console.WriteLine("           ");
        Console.WriteLine("           𝓜𝓮𝓷𝓾");
        Console.WriteLine("   - - ┈┈∘┈˃̶༒˂̶┈∘┈┈ - -");
        Console.WriteLine("✧ 𝓑𝓻𝓮𝓪𝓭 𝓛𝓸𝓪𝓯     $5.00");
        Console.WriteLine("✧ 𝓟𝓪𝓼𝓽𝓻𝔂         $2.00");
        Console.WriteLine("           ");
        Console.WriteLine(".·:*¨༺  𝔻𝕒𝕚𝕝𝕪 𝕤𝕡𝕖𝕔𝕚𝕒𝕝 𝕗𝕣𝕠𝕞 𝟙 - 𝟝𝕡𝕞 ༻¨*:·.");
        Console.WriteLine("           ");
        Console.WriteLine("✧ 𝔹𝕦𝕪 𝟚 𝕓𝕣𝕖𝕒𝕕 𝕝𝕠𝕒𝕧𝕖𝕤 𝕘𝕖𝕥 𝟙 𝔽ℝ𝔼𝔼");
        Console.WriteLine("✧ 𝔹𝕦𝕪 𝟛 𝕡𝕒𝕤𝕥𝕣𝕚𝕖𝕤 𝕘𝕖𝕥 𝟙 𝔽ℝ𝔼𝔼");
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