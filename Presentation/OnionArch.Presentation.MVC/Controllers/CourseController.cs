using Microsoft.AspNetCore.Mvc;

namespace OnionArch.Presentation.MVC.Controllers
{
    public class CourseController : Controller
    {

        public CourseController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}