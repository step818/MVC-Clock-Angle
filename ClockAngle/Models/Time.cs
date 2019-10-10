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
    public string Validate()
    {
      if(Hour < 1 || Hour > 12)
      {
        return "Error: Please enter a valid time";
      }
      else
      {
        return "";
      }
    }
    public int Angle()
    {
      if(Hour == 12)
      {
        Hour = 0;
      }
      int degreesInHrs = Hour * 30;
      int degreesInMins = Minute * 6;
      int constantMovingHour = (Minute/10);
      Console.WriteLine(Minute/10);
      if ((Minute/5) >= Hour)
      {
        _angle = (degreesInMins-constantMovingHour) - degreesInHrs;
      if(_angle < 0)
        {
          _angle = _angle * -1;
        }
      }
      else
      {
        _angle = degreesInHrs - degreesInMins;
        if(_angle < 0)
        {
          _angle = _angle * -1;
        }
      }
      return _angle;
    }
    public int ExplementaryAngle()
    {
      return (360 - _angle);
    }
  }
}