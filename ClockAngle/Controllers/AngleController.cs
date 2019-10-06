using Microsoft.AspNetCore.Mvc;
using ClockAngle.Models;

namespace ClockAngle.Controllers
{
  public class AngleController : Controller
  {
    [Route("/angle")]
    public ActionResult Index()
    {
      return View();
    }
  }
}