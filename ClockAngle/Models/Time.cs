using System;

namespace ClockAngle.Models
{
  public class Time
  {
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Angle(int hour, int minute)
    {
      Hour = hour;
      Minute = minute;
      Time newTime = new Time();
      return Hour;
    }
  }
}