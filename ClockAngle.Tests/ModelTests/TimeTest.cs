using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle.Models;
using System;

namespace ClockAngle.Tests
{
  [TestClass]
  public class TimeTest
  {
    [TestMethod]
    public void Angle_ConvertToDegrees_Int()
    {
      Time newTime = new Time(5, 30);
      int result = newTime.Angle();
      Assert.AreEqual(530, result);
    }
  }
}