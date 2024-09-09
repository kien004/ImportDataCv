using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductLocatedMapping
{
    public int Id { get; set; }

    public int? IdImpProduct { get; set; }

    public string? MappingCode { get; set; }

    public string? ProductCode { get; set; }

    public string? WhsCode { get; set; }

    public string? MappingLog { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Weight { get; set; }

    public string? ProductNo { get; set; }

    public decimal? QuantityTemp { get; set; }

    public decimal? WeightTemp { get; set; }

    public string? ProductNoTemp { get; set; }

    public string? GattrCode { get; set; }

    public string? Unit { get; set; }

    public string? Ordering { get; set; }

    public string? TicketImpCode { get; set; }

    public string? FloorCode { get; set; }

    public string? LineCode { get; set; }

    public string? RackCode { get; set; }

    public string? RackPosition { get; set; }

    public bool? IsCustomized { get; set; }

    public string? ProdCustomJson { get; set; }

    public string? ProductQrCode { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletionToken { get; set; }
}
