using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrWorkingProcess
{
    public int Id { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? WageLevel { get; set; }

    public DateTime? EndDate { get; set; }

    public double? SalaryRatio { get; set; }

    public int EmployeeId { get; set; }

    public string? Description { get; set; }

    public DateTime? StartTime { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? Flag { get; set; }
}
