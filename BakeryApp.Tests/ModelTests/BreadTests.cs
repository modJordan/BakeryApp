using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp;
using System.Collections.Generic;
using System;

namespace BakeryApp.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CreatesInstanceOfBreadPrice_Bread()
    {
      Bread newBread = new Bread(2);

      Assert.AreEqual(10, Bread.CalculateCost(2));
    }
  }
}