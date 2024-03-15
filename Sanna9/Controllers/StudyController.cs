using Microsoft.AspNetCore.Mvc;

namespace Sanna9.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lessons()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
