using LvdtLesson06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LvdtLesson06.Controllers
{
    public class HomeController : Controller
    {
        // View Action Index của HomeController load danh sách sản phẩm mới nhất
        public IActionResult Index()
        {
            var newProducts = ProductData.GetNewProducts(3);
            return View(newProducts);
        }

        // View Action trả về PartialView danh sách sản phẩm mới nhất theo yêu cầu
        public IActionResult NewProduct()
        {
            var newProducts = ProductData.GetNewProducts(3);
            return PartialView("_NewProductPartial", newProducts);
        }

        public IActionResult Privacy()
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
