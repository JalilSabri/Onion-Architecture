using Microsoft.AspNetCore.Mvc;

namespace OnionArch.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}