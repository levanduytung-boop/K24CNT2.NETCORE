using Microsoft.AspNetCore.Mvc;
using LvdtLesson06.Models;

namespace LvdtLesson06.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var hotProducts = ProductData.GetHotProducts(3);
            return View(hotProducts);
        }
    }
}
