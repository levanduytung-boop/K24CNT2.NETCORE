using System;
using System.Collections.Generic;

namespace LvdtLesson10.Models;

public partial class LvdtMember
{
    public long Id { get; set; }

    public string? LvdtUserName { get; set; }

    public string? LvdtPassword { get; set; }

    public string? LvdtFullname { get; set; }

    public string? LvdtEmail { get; set; }

    public string? LvdtPhone { get; set; }

    public bool? LvdtStatus { get; set; }
}
