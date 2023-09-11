using Microsoft.AspNetCore.Mvc;
using NetCoreMVCBTk.Models;

namespace NetCoreMVCBTk.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply(Candidate cdt)
        {
            return View();
        }
    }
}