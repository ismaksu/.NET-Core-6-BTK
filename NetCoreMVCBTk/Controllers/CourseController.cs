using Microsoft.AspNetCore.Mvc;
using NetCoreMVCBTk.Models;

namespace NetCoreMVCBTk.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate cdt)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(cdt.Email)))
            {
                ModelState.AddModelError("", "The mail address you entered already registered.");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(cdt);
                return View("Feedback", cdt);
            }
            return View();
        }
    }
}