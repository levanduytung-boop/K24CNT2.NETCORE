namespace LvdtLesson09Annotation.Models;
public class LvdtMember
{
    public int LvdtMemberId { get; set; }
    public string LvdtMemberName { get; set; } = "";
    public string LvdtPassword { get; set; } = "";
    public string LvdtEmail { get; set; } = "";
    public string LvdtPhoneNumber { get; set; } = "";
    public string LvdtFullName { get; set; } = "";
    public DateTime LvdtBirthday { get; set; }
}
