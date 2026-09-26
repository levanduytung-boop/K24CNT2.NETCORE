using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LeVanDuyTung2410900085_exam.Models;
using Microsoft.EntityFrameworkCore;

namespace LeVanDuyTung2410900085_exam.Controllers;

public class HomeController : Controller
{
    private readonly LvdtDbContext _context;

    public HomeController(LvdtDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.TotalEmployees = await _context.LvdtEmployees.CountAsync();
        ViewBag.ActiveEmployees = await _context.LvdtEmployees.CountAsync(e => e.LvdtActive);
        ViewBag.TotalStudents = await _context.LvdtStudents.CountAsync();
        return View();
    }

    // Yêu cầu 3: Controller Home - Action HvtAbout - Hiển thị thông tin sinh viên
    public IActionResult HvtAbout()
    {
        ViewBag.HoTen = "Lê Văn Duy Tùng";
        ViewBag.MaSV = "2410900085";
        ViewBag.Lop = "K24CNT2";
        ViewBag.Khoa = "Công nghệ Thông tin";
        ViewBag.NgaySinh = "15/05/2006";
        ViewBag.GioiTinh = "Nam";
        ViewBag.Email = "tung.levanduy@gmail.com";
        ViewBag.Phone = "0912345678";
        ViewBag.DiaChi = "Hà Nội, Việt Nam";
        ViewBag.MonHoc = "Phát triển ứng dụng Web với ASP.NET Core MVC";
        ViewBag.DeTai = "Bài thi kiểm tra MVC - Quản lý HvtEmployee / HvtStudent";
        return View();
    }

    // Action alias LvdtAbout để hỗ trợ cả 2 đường dẫn Home/HvtAbout và Home/LvdtAbout
    public IActionResult LvdtAbout()
    {
        return HvtAbout();
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
