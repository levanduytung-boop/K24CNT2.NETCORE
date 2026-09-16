using Microsoft.AspNetCore.Mvc;
using LvdtLesson08Models.Models;

namespace LvdtLesson08Models.Controllers
{
    public class LvdtMemberController : Controller
    {
        private static readonly List<LvdtMember> _members = new()
        {
            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "Tungtv",
                LvdtPassword = "Password123!",
                LvdtFullName = "Lê Văn Duy Tùng",
                LvdtEmail = "duytunglevan@gmail.com"
            },
            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "tranthib",
                LvdtPassword = "SecurePass456#",
                LvdtFullName = "Trần Thị B",
                LvdtEmail = "tranthib@outlook.com"
            },
            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "levanc",
                LvdtPassword = "MyPassword789$",
                LvdtFullName = "Lê Văn C",
                LvdtEmail = "levanc@company.com"
            }
        };

        public IActionResult Index()
        {
            return View(_members);
        }

        [HttpGet]
        public IActionResult LvdtCreate()
        {
            return View(new LvdtMember());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LvdtCreate(LvdtMember LvdtMember)
        {
            if (!ModelState.IsValid)
                return View(LvdtMember);

            LvdtMember.LvdtMemberId = Guid.NewGuid().ToString();
            _members.Add(LvdtMember);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult LvdtEdit(string id)
        {
            var member = _members.FirstOrDefault(x => x.LvdtMemberId == id);
            if (member == null) return NotFound();
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LvdtEdit(string id, LvdtMember LvdtMember)
        {
            if (!ModelState.IsValid)
            {
                LvdtMember.LvdtMemberId = id;
                return View(LvdtMember);
            }

            var member = _members.FirstOrDefault(x => x.LvdtMemberId == id);
            if (member == null) return NotFound();

            member.LvdtUserName = LvdtMember.LvdtUserName;
            member.LvdtPassword = LvdtMember.LvdtPassword;
            member.LvdtFullName = LvdtMember.LvdtFullName;
            member.LvdtEmail = LvdtMember.LvdtEmail;

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult LvdtDetails(string id)
        {
            var member = _members.FirstOrDefault(x => x.LvdtMemberId == id);
            if (member == null) return NotFound();
            return View(member);
        }

        [HttpGet]
        public IActionResult LvdtDelete(string id)
        {
            var member = _members.FirstOrDefault(x => x.LvdtMemberId == id);
            if (member == null) return NotFound();
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LvdtDeleted(string id)
        {
            var member = _members.FirstOrDefault(x => x.LvdtMemberId == id);
            if (member != null)
                _members.Remove(member);

            return RedirectToAction(nameof(Index));
        }
    }
}
