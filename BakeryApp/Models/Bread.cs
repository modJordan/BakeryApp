using System.Collections.Generic;

namespace BakeryApp.Models
{
  public class Bread
  {
    public static int CostPerLoaf = 5;

    public static int CalculateCost(int numberOfLoaves)
    {
      int freeLoaves = numberOfLoaves / 3;
      return (numberOfLoaves - freeLoaves) * CostPerLoaf;
    }
  }

  public class Pastry
  {
    public static int CostPerPastry = 2;

    public static int CalculateCost(int numberOfPastries)
    {
      int freePastries = numberOfPastries / 4;
      return (numberOfPastries - freePastries) * CostPerPastry;
    }
  }
}

