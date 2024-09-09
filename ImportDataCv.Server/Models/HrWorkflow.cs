using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrWorkflow
{
    public int Id { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? WorkingProcess { get; set; }

    public int EmployeeId { get; set; }

    public string? Description { get; set; }

    public string? NameJob { get; set; }

    public string? InfoDetails { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? Flag { get; set; }
}
