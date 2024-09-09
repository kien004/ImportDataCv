using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrEmployeeMobilization
{
    public int Id { get; set; }

    public string? DecisionId { get; set; }

    public string? EmployeeId { get; set; }

    public string? DepartmentIdOld { get; set; }

    public string? RoleIdOld { get; set; }

    public string? DepartmentIdNew { get; set; }

    public string? RoleIdNew { get; set; }

    public string? Wage { get; set; }

    public string? WageLevel { get; set; }

    public string? Reason { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? FormDate { get; set; }

    public DateTime? ToDate { get; set; }
}
