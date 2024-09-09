using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EmployeeCoaching
{
    public int Id { get; set; }

    public string? CoachType { get; set; }

    public int? CoachId { get; set; }

    public string? CardCode { get; set; }

    public string? ItemCode { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
