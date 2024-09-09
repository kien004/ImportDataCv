using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkOsList
{
    public int ListId { get; set; }

    public string ListCode { get; set; } = null!;

    public string? ListName { get; set; }

    public string? BoardCode { get; set; }

    public int Order { get; set; }

    public string? Avatar { get; set; }

    /// <summary>
    /// 0: Khởi tạo - 1: Hoạt động - 2: Chậm trế
    /// </summary>
    public int? Status { get; set; }

    public string? Background { get; set; }

    public decimal Completed { get; set; }

    public DateTime? CompletedTime { get; set; }

    public decimal? Cost { get; set; }

    public DateTime Deadline { get; set; }

    public string? LocationText { get; set; }

    public string? LocationGps { get; set; }

    public string? Device { get; set; }

    public DateTime BeginTime { get; set; }

    public decimal WeightNum { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool IsDeleted { get; set; }
}
