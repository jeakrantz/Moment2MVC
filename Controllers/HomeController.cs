using Microsoft.AspNetCore.Mvc;

namespace Moment2MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() {
        return View();
    }
    [Route("/om")]
    public IActionResult About() {
        return View();
    }
    [Route("/formular")]
    public IActionResult Form() {
        return View();
    }


}