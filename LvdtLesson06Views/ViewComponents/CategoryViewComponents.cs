using LvdtLesson06Views.Models;
using Microsoft.AspNetCore.Mvc;

namespace LvdtLesson06Views.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            var categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Electronics", status = true },
            new Category { CategoryId = 2, CategoryName = "Books", status = true },
            new Category { CategoryId = 3, CategoryName = "Clothing", status = false },
            new Category { CategoryId = 4, CategoryName = "Home & Kitchen", status = true }
        };
            n = n ?? 0;
            var search = categories.Where(x => x.CategoryId >= n).ToList();
            return View(search);
        }
      }
    }