using LvdtLesson05Views.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LvdtLesson05Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        // lập trình trên view với Razor code
        public ActionResult RazorCode() 
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
