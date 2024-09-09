﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectMember
{
    public int Id { get; set; }

    public string? ProjectCode { get; set; }

    public string? MemberCode { get; set; }

    public string? Position { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool FlagDeleted { get; set; }
}
