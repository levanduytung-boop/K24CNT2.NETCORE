using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LvdtLesson08Models.Models;

namespace LvdtLesson08Models.Controllers
{
    public class LvdtHomeController : Controller
    {
        private readonly ILogger<LvdtHomeController> _logger;

        public LvdtHomeController(ILogger<LvdtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LvdtIndex()
        {
            return View();
        }

        public IActionResult LvdtPrivacy()
        {
            return View();
        }

        public IActionResult LvdtAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
