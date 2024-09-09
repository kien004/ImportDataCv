using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WalletPackage
{
    public int Id { get; set; }

    public string? PackageCode { get; set; }

    public string? PackageName { get; set; }

    public string? Description { get; set; }

    public string? ConditionJson { get; set; }

    public string? Status { get; set; }

    public decimal? Duration { get; set; }

    public string? DurationUnit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
