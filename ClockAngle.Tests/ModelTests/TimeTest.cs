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
      Assert.AreEqual(30, result);
    }
    [TestMethod]
    public void Angle_ElseToDegrees_Int()
    {
      Time newTime = new Time(2, 05);
      int result = newTime.Angle();
      Assert.AreEqual(30, result);
    }
  }
}