using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EmployeeStatusTracking
{
    public int Id { get; set; }

    public string? EmployeeCode { get; set; }

    public string? StatusCode { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectRelative { get; set; }
}
