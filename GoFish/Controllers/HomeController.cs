using Microsoft.AspNetCore.Mvc;

namespace GoFish.Controllers
{
  public class HomeController : Controllers
  {

    [HttpGet(/)]
    public ActionResult Index()
    {
      return View();
    }
  }
}