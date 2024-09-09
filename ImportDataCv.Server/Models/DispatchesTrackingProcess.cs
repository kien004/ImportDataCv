using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DispatchesTrackingProcess
{
    public int Id { get; set; }

    public string? DispatchCode { get; set; }

    public string? FromNode { get; set; }

    public string? NodeProars { get; set; }

    public bool? IsUp { get; set; }

    public DateTime? DeadLine { get; set; }

    public string? MemberList { get; set; }

    public string? ProcessCode { get; set; }

    public string? Comment { get; set; }

    public string? FileList { get; set; }

    public string? Status { get; set; }

    public string? ToNode { get; set; }

    public string? Action { get; set; }

    public int? Step { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Reason { get; set; }

    public string? Coordinate { get; set; }

    public string? Received { get; set; }

    public string? ViewerList { get; set; }
}
