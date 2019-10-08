using System;
using System.ComponentModel;

namespace ClockAngle.Models
{
  public class Time
  {
    public int Hour { get; set; }
    public int Minute { get; set; }
    private int _angle = 0;
    public Time(int hour, int minute)
    {
      Hour = hour;
      Minute = minute;
      _angle = 0;
    }
    public int Angle()
    {
      Console.WriteLine(Minute);
      return _angle + Hour;
    }
  }
}