using Formularz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Formularz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Form", new Dane());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Dane model)
        {
            if (ModelState.IsValid)
            {
                return View("Summary", model);
            }

            return View("Form", model);
        }

        public IActionResult Summary(Dane model)
        {
            return View(model);
        }
    }
}
