using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomRt
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public decimal? Quantity { get; set; }

    public string? Range { get; set; }

    public string? Unit { get; set; }

    public string? Specification { get; set; }

    public string? Io { get; set; }

    public string? ActivityCode { get; set; }

    public string? ShiftCode { get; set; }

    public string? WorkOrderCode { get; set; }

    public string? WorkedBy { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectCode { get; set; }

    public string? ParentId { get; set; }

    public decimal? Ng { get; set; }

    public int? LotNumber { get; set; }

    public string? LotCode { get; set; }

    public string? GattrCode { get; set; }

    public string? TypeImpExp { get; set; }

    public string? Postfix { get; set; }

    public string? Machine { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
