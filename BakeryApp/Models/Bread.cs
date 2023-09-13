using System.Collections.Generic;

namespace BakeryApp.Models
{
  public class Bread
  {
    private static int _costPerLoaf = 5;

    public static int CostPerLoaf
    {
      get { return _costPerLoaf; }
      set { _costPerLoaf = value; }
    }

    public static int CalculateCost(int numberOfLoaves)
    {
      int freeLoaves = numberOfLoaves / 3;
      return (numberOfLoaves - freeLoaves) * CostPerLoaf;
    }
  }

  public class Pastry
  {
    private static int _costPerPastry = 2;

    public static int CostPerPastry
    {
      get { return _costPerPastry; }
      set { _costPerPastry = value; }
    }


    public static int CalculateCost(int numberOfPastries)
    {
      int freePastries = numberOfPastries / 4;
      return (numberOfPastries - freePastries) * CostPerPastry;
    }
  }
}

