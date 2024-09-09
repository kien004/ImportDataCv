using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrAddress
{
    public int Id { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? NowAddress { get; set; }

    public string? Phone { get; set; }

    public string? PermanentAddress { get; set; }

    public int EmployeeId { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? Flag { get; set; }
}
