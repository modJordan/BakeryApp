using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace BakeryApp.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]
    public void BreadCostCalculation_CalculateForTwoLoaves_Ten()
    {
      //Arrange
      int numberOfLoaves = 2;

      //Act
      int result = Bread.CalculateCost(numberOfLoaves);

      //Assert
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void BreadCostCalculation_CalculateForThreeLoaves_Ten()
    {
      // Arrange
      int numberOfLoaves = 3;

      //Act
      int result = Bread.CalculateCost(numberOfLoaves);

      //Assert
      Assert.AreEqual(10, result);
    }
  }
}