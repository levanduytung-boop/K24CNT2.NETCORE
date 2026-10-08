using System.ComponentModel.DataAnnotations;
namespace LvdtLesson09Annotation.Models;
public class LvdtMemberRegister
{
    public int LvdtMemberId { get; set; }
    [Display(Name = "Tên đăng nhập")]
    [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập phải có từ 3 đến 20 ký tự")]
    public string LvdtUserName { get; set; } = "";
    [Display(Name = "Mật khẩu")]
    [Required(ErrorMessage = "Mật khẩu không được để trống")]
    [DataType(DataType.Password)]
    public string LvdtPassword { get; set; } = "";
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email không được để trống")]
    [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
    public string LvdtEmail { get; set; } = "";
    [Display(Name = "Số điện thoại")]
    [RegularExpression(@"^0\d{9}$", ErrorMessage = "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0")]
    public string? LvdtPhoneNumber { get; set; }
    [Display(Name = "Họ và tên")]
    [Required(ErrorMessage = "Họ và tên không được để trống")]
    public string LvdtFullName { get; set; } = "";
    [Display(Name = "Ngày sinh")]
    [DataType(DataType.Date)]
    public DateTime LvdtBirthday { get; set; } = DateTime.Today;
}
