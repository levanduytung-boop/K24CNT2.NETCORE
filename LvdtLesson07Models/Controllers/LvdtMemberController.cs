using Microsoft.AspNetCore.Mvc;
using LvdtLesson07Models.Models.DataModels;

namespace LvdtLesson07Models.Controllers
{
    public class LvdtMemberController : Controller
    {
        // Mock Data
        protected static List<LvdtMember> _members = new List<LvdtMember>
        {
            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "tungtv",
                LvdtPassword = "123456",
                LvdtFullName = "Lê Văn Duy Tùng",
                LvdtEmail = "duytunglevan@gmail.com"
            },

            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "tranthibinh",
                LvdtPassword = "123456",
                LvdtFullName = "Trần Thị Bình",
                LvdtEmail = "tranthibinh@example.com"
            },

            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "levancuong",
                LvdtPassword = "123456",
                LvdtFullName = "Lê Văn Cường",
                LvdtEmail = "levancuong@example.com"
            },

            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "phamthiduyen",
                LvdtPassword = "123456",
                LvdtFullName = "Phạm Thị Duyên",
                LvdtEmail = "phamthiduyen@example.com"
            },

            new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "hoangminhduc",
                LvdtPassword = "123456",
                LvdtFullName = "Hoàng Minh Đức",
                LvdtEmail = "hoangminhduc@example.com"
            }
        };

        public IActionResult Index()
        {
            return View(_members);
        }

        public IActionResult GetMember()
        {
            var member = new LvdtMember
            {
                LvdtMemberId = Guid.NewGuid().ToString(),
                LvdtUserName = "tungtv",
                LvdtPassword = "password123",
                LvdtFullName = "Lê Văn Duy Tùng",
                LvdtEmail = "duytung@gmail.com"
            };

            return View(member);
        }

        // Đưa dữ liệu dạng List ra View
        public IActionResult GetMembers()
        {
            // Lấy từ mock data
            ViewBag.Members = _members;

            return View();
        }

        // GET: Create member
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create member
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LvdtMember member)
        {
            if (ModelState.IsValid)
            {
                member.LvdtMemberId = Guid.NewGuid().ToString();

                _members.Add(member);

                return RedirectToAction(nameof(Index));
            }

            return View(member);
        }
    }
}