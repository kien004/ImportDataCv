﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PlanRecruitmentHeader
{
    public int Id { get; set; }

    public string? PlanNumber { get; set; }

    public string? Title { get; set; }

    public string? PlanType { get; set; }

    public string? Note { get; set; }

    public string? DepartmentCode { get; set; }

    public string? UserCreated { get; set; }

    public DateTime? PlanDate { get; set; }

    public string? WorkflowCat { get; set; }

    public string? Status { get; set; }

    public string? StatusLog { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? JsonData { get; set; }
}
