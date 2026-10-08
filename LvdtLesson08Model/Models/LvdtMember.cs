using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LvdtLesson08Models.Models
{
    public class LvdtMember
    {
        public string LvdtMemberId { get; set; } = string.Empty;

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        public string LvdtUserName { get; set; } = string.Empty;

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string LvdtPassword { get; set; } = string.Empty;

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string LvdtFullName { get; set; } = string.Empty;

        [DisplayName("Email")]
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string LvdtEmail { get; set; } = string.Empty;
    }
}
