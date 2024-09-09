using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetAllocateDetail
{
    public int Id { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? AssetCode { get; set; }

    public int? Quantity { get; set; }

    public string? CostValue { get; set; }

    public string? ListImages { get; set; }

    public string? Status { get; set; }

    public string? TicketCode { get; set; }
}
