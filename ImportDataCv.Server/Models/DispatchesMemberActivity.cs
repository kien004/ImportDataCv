using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DispatchesMemberActivity
{
    public int Id { get; set; }

    public string? ProcessCode { get; set; }

    public string? Assigner { get; set; }

    public string? UserId { get; set; }

    public int? Role { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? GroupUserCode { get; set; }

    public string? Comment { get; set; }

    public string? AssigneeConfirm { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public DateTime? DeadLine { get; set; }
}
