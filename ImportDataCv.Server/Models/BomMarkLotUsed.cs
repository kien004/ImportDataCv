using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomMarkLotUsed
{
    public int Id { get; set; }

    public string? Io { get; set; }

    public string? ActivityCode { get; set; }

    public string? ActivityDestination { get; set; }

    public string? Status { get; set; }

    public int? LotNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
