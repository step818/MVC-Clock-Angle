using System;

namespace ClockAngle.Models
{
  public class Time
  {
    public int Hour { get; set; }
    public int Minute { get; set; }
    public Time(int hour, int minute)
    {
      Hour = hour;
      Minute = minute;
    }
    public int Angle()
    {
      return (Hour*100) + Minute;
    }
  }
}