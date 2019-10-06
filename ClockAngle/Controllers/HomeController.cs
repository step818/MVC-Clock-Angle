using Microsoft.AspNetCore.Mvc;
using ClockAngle.Models;

namespace ClockAngle.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}