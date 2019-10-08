using System;

namespace ClockAngle.Models
{
  public class Time
  {
    public int Hour { get; set; }
    public int Minute { get; set; }
    private int _angle;
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