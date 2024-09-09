using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomGattrExt
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public string? ActivityCode { get; set; }

    public int? LotNumber { get; set; }

    public int? ItemId { get; set; }

    public string? GattrJson { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletionToken { get; set; }
}
