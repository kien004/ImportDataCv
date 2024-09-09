using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LotProduct
{
    public int Id { get; set; }

    public string? QrCode { get; set; }

    public string? BarCode { get; set; }

    public string? Title { get; set; }

    public string? Supplier { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? Cost { get; set; }

    public string? Unit { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? PathImg { get; set; }

    public string? LotProductCode { get; set; }

    public string? Packing { get; set; }

    public decimal? Tax { get; set; }

    public decimal? CustomFee { get; set; }

    public decimal? PoundAge { get; set; }

    public decimal? TransferCost { get; set; }

    public decimal? Discount { get; set; }

    public string? Note { get; set; }

    public string? LotProductName { get; set; }

    public int? Store { get; set; }

    /// <summary>
    /// xuất xứ
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Ngày sản xuất
    /// </summary>
    public DateTime? ManufactureDate { get; set; }

    public string? Currency { get; set; }

    public decimal? TaxMedium { get; set; }

    public decimal? CostMedium { get; set; }
}
