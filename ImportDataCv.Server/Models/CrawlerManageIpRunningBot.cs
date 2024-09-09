using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerManageIpRunningBot
{
    public int Id { get; set; }

    public string? RobotCode { get; set; }

    public string? RobotName { get; set; }

    public string? IpComputer { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public int? PortComputer { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
