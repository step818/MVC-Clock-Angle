using Microsoft.AspNetCore.Mvc;
using ClockAngle.Models;

namespace ClockAngle.Controllers
{
  public class AngleController : Controller
  {
    [Route("/calculated")]
    public ActionResult Index(int hour, int minute)
    {
      Time newTime = new Time(hour, minute);
      newTime.Hour = hour;
      newTime.Minute = minute;
      
      return View(newTime);
    }
  }
}