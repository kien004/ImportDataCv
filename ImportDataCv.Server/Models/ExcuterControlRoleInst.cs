﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ExcuterControlRoleInst
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Role { get; set; }

    public string? DepartmentCode { get; set; }

    public string? GroupCode { get; set; }

    public string? ActivityCodeInst { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? Approve { get; set; }

    public DateTime? ApproveTime { get; set; }

    public string? Branch { get; set; }

    public string? Status { get; set; }
}
