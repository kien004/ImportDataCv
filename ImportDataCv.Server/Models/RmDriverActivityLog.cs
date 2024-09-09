using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmDriverActivityLog
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? CdataJson { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? SysDate { get; set; }

    public string? Chanel { get; set; }

    public string? NodeGis { get; set; }

    public int? DriverId { get; set; }
}
