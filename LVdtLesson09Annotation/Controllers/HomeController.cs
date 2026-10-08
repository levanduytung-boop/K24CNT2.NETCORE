using Microsoft.AspNetCore.Mvc;
namespace LvdtLesson09Annotation.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult LvdtAbout() => View();
    public IActionResult Error() => View();
}
