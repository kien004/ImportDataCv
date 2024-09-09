using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FundAccEntryTracking
{
    public int Id { get; set; }

    public string AetCode { get; set; } = null!;

    public string? Action { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public string? FromDevice { get; set; }

    public string? LocationText { get; set; }

    public string? LocationGps { get; set; }

    public bool IsDeleted { get; set; }
}
