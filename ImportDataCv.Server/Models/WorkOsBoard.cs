using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkOsBoard
{
    public int BoardId { get; set; }

    public string? BoardCode { get; set; }

    public string? BoardName { get; set; }

    public string? TeamCode { get; set; }

    public string? Avatar { get; set; }

    public string? Visibility { get; set; }

    public string? BackgroundColor { get; set; }

    public string? BackgroundImage { get; set; }

    public string? BoardType { get; set; }

    public decimal Completed { get; set; }

    public DateTime? CompletedTime { get; set; }

    public decimal? Cost { get; set; }

    public DateTime Deadline { get; set; }

    public string? LocationText { get; set; }

    public string? LocationGps { get; set; }

    public string? Device { get; set; }

    public DateTime BeginTime { get; set; }

    public string? UpdateBy { get; set; }

    public string? Branch { get; set; }

    public string? Department { get; set; }

    public int? CountAll { get; set; }

    public int? CountProgress { get; set; }

    public int? CountCompleted { get; set; }

    public int? CountExpired { get; set; }

    public int? CountCanceled { get; set; }

    public bool IsDeleted { get; set; }
}
