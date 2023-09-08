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

    [TestMethod]
    public void BreadCostCalculation_CalculateForFourLoaves_Fifteen()
    {
      //Arrange
      int numberOfLoaves = 4;

      //Act
      int result = Bread.CalculateCost(numberOfLoaves);

      //Assert
      Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void BreadCostCalculation_CalculateForSevenLoaves_TwentyFive()
    {
      //Arrange 
      int numberOfLoaves = 7;

      //Act 
      int result = Bread.CalculateCost(numberOfLoaves);

      //Assert
      Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void PastryCostCalculation_CalculateForTwoPastries_Four()
    {

      //Arrange
      int numberOfPastries = 2;

      //Act 
      int result = Pastry.CalculateCost(numberOfPastries);

      //Assert
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void PastryCostCalculation_CalculateForThreePastries_Six()
    {
      //Arrange
      int numberOfPastries = 3;

      //Act 
      int result = Pastry.CalculateCost(numberOfPastries);

      //Assert
      Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void PastryCostCalculation_CalculateForFourPastries_Six()
    {
      //Arrange
      int numberOfPastries = 4;

      //Act 
      int result = Pastry.CalculateCost(numberOfPastries);

      //Assert
      Assert.AreEqual(6, result);
    }
  }
}