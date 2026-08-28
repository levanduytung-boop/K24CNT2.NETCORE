
using Microsoft.AspNetCore.Mvc;
using LvdtLesson03.Models;
namespace LvdtLesson03.Controllers
{
    [Route("/danh-sach-san-pham")]
    public class LvdtProductController : Controller
    {
        // Mock data
        private readonly List<LvdtProduct> _products = new()
        {
            new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-001",
        LvdtProductName = "iPhone 15 Pro Max 256GB",
        LvdtYearRelease = 2023,
        LvdtPrice = 29990000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-002",
        LvdtProductName = "Samsung Galaxy S24 Ultra 512GB",
        LvdtYearRelease = 2024,
        LvdtPrice = 31490000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-003",
        LvdtProductName = "Xiaomi 14 Ultra 5G",
        LvdtYearRelease = 2024,
        LvdtPrice = 27990000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-004",
        LvdtProductName = "Google Pixel 8 Pro 128GB",
        LvdtYearRelease = 2023,
        LvdtPrice = 21500000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-005",
        LvdtProductName = "OPPO Find N3 Flip 256GB",
        LvdtYearRelease = 2023,
        LvdtPrice = 22990000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-006",
        LvdtProductName = "iPad Pro M4 11 inch 256GB",
        LvdtYearRelease = 2024,
        LvdtPrice = 28990000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-007",
        LvdtProductName = "Samsung Galaxy Tab S9 Ultra",
        LvdtYearRelease = 2023,
        LvdtPrice = 24990000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-008",
        LvdtProductName = "Asus ROG Phone 8 Pro 512GB",
        LvdtYearRelease = 2024,
        LvdtPrice = 29490000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-009",
        LvdtProductName = "Vivo X100 Pro 5G",
        LvdtYearRelease = 2024,
        LvdtPrice = 20990000m
    },
    new LvdtProduct
    {
        LvdtProductId = "LVDT-MB-010",
        LvdtProductName = "Sony Xperia 1 VI 256GB",
        LvdtYearRelease = 2024,
        LvdtPrice = 32990000m
    }
        };
        public IActionResult Index()
        {
            return Json(_products);
        }


        // collection => view
        [Route("all")]
        public IActionResult LvdtGetAllProduct()
        {
            ViewData["Products"] = _products;
            return View();
        }
    }
}
