using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class InventoryAuditDetail
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? ParentId { get; set; }

    public string? AuditTickCode { get; set; }

    public string? ProductNo { get; set; }

    public string? AuditType { get; set; }

    public string? GattrCode { get; set; }

    public string? Image { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public decimal? Measurement { get; set; }

    public string? MeasurementUnit { get; set; }

    public string? Position { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletionToken { get; set; }

    public bool IsDeleted { get; set; }

    public string? LotProductCode { get; set; }

    public string? ProductQrCode { get; set; }

    public string? ProductType { get; set; }

    public bool? MarkWholeProduct { get; set; }

    public string? PackCode { get; set; }

    public string? ProdCustomJson { get; set; }

    public bool? IsCustomized { get; set; }

    public int? MapId { get; set; }
}
