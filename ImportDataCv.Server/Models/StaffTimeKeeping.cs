using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class StaffTimeKeeping
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public string? UserName { get; set; }

    public string? DepartmentCode { get; set; }

    public string? Name { get; set; }

    public string? Month { get; set; }

    public string? JsonMonth { get; set; }

    public decimal? TotalDay { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletionToken { get; set; }
}
