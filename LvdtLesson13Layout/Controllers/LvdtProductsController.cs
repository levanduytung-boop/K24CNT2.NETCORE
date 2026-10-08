using Microsoft.AspNetCore.Mvc;

namespace LvdtLesson13Layout.Controllers
{
    public class LvdtProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string keyword)
        {
            ViewData["keyword"] = keyword;
            return View();
        }

        public IActionResult Hots()
        {

            return View();
        }
    }
}
