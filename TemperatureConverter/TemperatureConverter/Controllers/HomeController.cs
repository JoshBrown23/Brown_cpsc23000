using System.Diagnostics;
using TemperatureConverter.Models;
using Microsoft.AspNetCore.Mvc;

namespace TemperatureConverter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Temp = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TempConverterModel tcm)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Temp = tcm.CalculateConversion();
            }
            else
            {
                ViewBag.Temp = 0;
            }
            return View(tcm);
        }

        public IActionResult Questions()
        {
            return View();
        }
    }
}
