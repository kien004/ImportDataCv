using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PlanRecruitmentDetail
{
    public int Id { get; set; }

    public string? PlanNumber { get; set; }

    public string? Position { get; set; }

    public string? Age { get; set; }

    public string? Gender { get; set; }

    public string? Level { get; set; }

    public string? Specialize { get; set; }

    public int? YearOfExperience { get; set; }

    public string? Tier { get; set; }

    public string? Local { get; set; }

    public int? Quantity { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
