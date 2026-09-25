using Microsoft.AspNetCore.Mvc;
using LvdtLesson09Annotation.Models;
namespace LvdtLesson09Annotation.Controllers;
public class LvdtMemberController : Controller
{
    private static readonly List<LvdtMember> Members = [];
    private static readonly object Gate = new();
    public IActionResult Index() { lock (Gate) return View(Members.ToList()); }
    public IActionResult Create() => View(new LvdtMemberRegister());
    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Create(LvdtMemberRegister model)
    {
        if (!ModelState.IsValid) return View(model);
        lock (Gate)
        {
            if (Members.Any(m => m.LvdtMemberName.Equals(model.LvdtUserName, StringComparison.OrdinalIgnoreCase)))
            { ModelState.AddModelError(nameof(model.LvdtUserName), "Tên đăng nhập đã tồn tại"); return View(model); }
            Members.Add(new LvdtMember { LvdtMemberId = Members.Count == 0 ? 1 : Members.Max(m => m.LvdtMemberId) + 1,
                LvdtMemberName = model.LvdtUserName, LvdtPassword = model.LvdtPassword,
                LvdtEmail = model.LvdtEmail, LvdtPhoneNumber = model.LvdtPhoneNumber ?? "",
                LvdtFullName = model.LvdtFullName, LvdtBirthday = model.LvdtBirthday });
        }
        TempData["Message"] = "Đăng ký thành viên thành công";
        return RedirectToAction(nameof(Index));
    }
}
