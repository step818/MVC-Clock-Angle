using System;
using System.ComponentModel;

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
      if(Hour == 12)
      {
        Hour = 0;
      }
      int degreesInHrs = Hour * 30;
      int degreesInMins = Minute * 6;
      if ((Minute/5) >= Hour)
      {
        _angle = degreesInMins - degreesInHrs;
      }
      else
      {
        _angle = degreesInHrs - degreesInMins;
      }
      return _angle;
    }
  }
}