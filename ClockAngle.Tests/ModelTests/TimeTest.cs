using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle.Models;
using System;

namespace ClockAngle.Tests
{
  [TestClass]
  public class TimeTest
  {
    [TestMethod]
    public void Angle_IfToDegrees_Int()
    {
      Time newTime = new Time(1, 10);
      int result = newTime.Angle();
      Assert.AreEqual(29, result);
    }
    [TestMethod]
    public void Angle_ElseToDegrees_Int()
    {
      Time newTime = new Time(2, 05);
      int result = newTime.Angle();
      Assert.AreEqual(30, result);
    }
    [TestMethod]
    public void Angle_MoreToDegrees_Int()
    {
      Time newTime = new Time(11, 56);
      int result = newTime.Angle();
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Angle_More2ToDegrees_Int()
    {
      Time newTime = new Time(12, 35);
      int result = newTime.Angle();
      Assert.AreEqual(207, result);
    }
    [TestMethod]
    public void Angle_More3ToDegrees_Int()
    {
      Time newTime = new Time(12, 59);
      int result = newTime.Angle();
      
      Assert.AreEqual(349, result);
    }
    [TestMethod]
    public void Angle_More4ToDegrees_Int()
    {
      Time newTime = new Time(1, 30);
      int result = newTime.Angle();
      Assert.AreEqual(147, result);
    }
  }
}