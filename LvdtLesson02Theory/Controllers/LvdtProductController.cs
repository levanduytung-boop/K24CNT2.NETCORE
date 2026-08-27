using Microsoft.AspNetCore.Mvc;
using LvdtLesson02Theory.Models;

namespace LvdtLesson02Theory.Controllers
{
    public class LvdtProductController : Controller
    {
        public IActionResult LvdtIndex()
        {
            // Dữ liệu lưu trong đối tượng: ViewBag; ViewData, TemData
            ViewBag.name = "Lê Văn Duy Tùng";
            ViewData["productVD"] = "Laptop Dell Vostro";
            TempData["UNI"] = "trường đại học Nguyễn Trãi - NTU";

            return View();
        }

        public IActionResult GetProduct()
        {
            // Tạo mock data product
            LvdtProduct lvdtProduct = new LvdtProduct
            {
                ProductID = "2410900085",
                ProductName = "Lê Văn Duy Tùng",
                YearRelease = 2003,
                Price = 1000
            };
            ;

            ViewBag.product = lvdtProduct;
            ViewData["product"] = lvdtProduct;
            return View("product");
        }
    }
}
