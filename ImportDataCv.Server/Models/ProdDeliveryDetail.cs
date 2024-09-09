using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProdDeliveryDetail
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? ProductCode { get; set; }

    public string? AttrCustom { get; set; }

    public string? ProductNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public decimal? SalePrice { get; set; }

    public string? Currency { get; set; }

    public int? TaxRate { get; set; }

    public int? Discount { get; set; }

    public int? Commission { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? ProductQrCode { get; set; }

    public string? LotProductCode { get; set; }

    public string? RackCode { get; set; }

    public string? ProductType { get; set; }

    public string? ProductCoil { get; set; }

    public int? MapId { get; set; }

    public bool? MarkWholeProduct { get; set; }

    public string? PackCode { get; set; }

    public string? ProdCustomJson { get; set; }

    public bool? IsCustomized { get; set; }

    public bool? IsInside { get; set; }

    public string? InsideOriginMap { get; set; }

    public string? InsideOriginNo { get; set; }

    public string? ProdParent { get; set; }

    public string? ExportDetailGroup { get; set; }
}
