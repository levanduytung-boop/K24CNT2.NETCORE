using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeVanDuyTung2410900085_exam.Models
{
    [Table("LvdtEmployee")]
    public class LvdtEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Mã nhân viên (Id)")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên nhân viên")]
        [StringLength(100, ErrorMessage = "Họ tên không được vượt quá 100 ký tự")]
        [Display(Name = "Họ và tên")]
        public string LvdtName { get; set; } = string.Empty;

        [Display(Name = "Giới tính")]
        public bool? LvdtGender { get; set; } = true; // true: Nam, false: Nữ

        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LvdtBirthDay { get; set; }

        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng")]
        [StringLength(100, ErrorMessage = "Email tối đa 100 ký tự")]
        [Display(Name = "Email")]
        public string? LvdtEmail { get; set; }

        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng số 0 và có từ 10 đến 11 chữ số")]
        [StringLength(20, ErrorMessage = "Số điện thoại tối đa 20 ký tự")]
        [Display(Name = "Số điện thoại")]
        public string? LvdtPhone { get; set; }

        [Display(Name = "Trạng thái hoạt động")]
        public bool LvdtActive { get; set; } = true;
    }
}
