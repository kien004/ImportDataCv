using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsBox
{
    public int Id { get; set; }

    public string? BoxCode { get; set; }

    public string? QrCode { get; set; }

    public string? DepartCode { get; set; }

    public string? TypeProfile { get; set; }

    public string? BoxSize { get; set; }

    public string? MCntBrief { get; set; }

    public string? CntBrief { get; set; }

    public DateTime? StartTime { get; set; }

    public string? NumBoxth { get; set; }

    public DateTime? StorageTime { get; set; }

    public string? Note { get; set; }

    public string? LstMemberId { get; set; }

    public string? StatusBox { get; set; }

    public string? WhsCode { get; set; }

    public string? FloorCode { get; set; }

    public string? LineCode { get; set; }

    public string? RackCode { get; set; }

    public string? CntCell { get; set; }

    public DateTime? EndTime { get; set; }

    public string? StatusSecurity { get; set; }

    public int? StoragePeriod { get; set; }

    public string? RqCode { get; set; }

    public string? LstTypeProfileId { get; set; }

    public string? RcCode { get; set; }

    public string? RackPosition { get; set; }

    public string? Ordering { get; set; }

    public bool? IsStored { get; set; }

    public string? RcExCode { get; set; }

    public string? RqExCode { get; set; }
}
