using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoSaleProductDetail
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ProductName { get; set; }

    public decimal? Quantity { get; set; }

    public string? GattrCode { get; set; }

    public string? Unit { get; set; }

    public decimal? Cost { get; set; }

    public string? ContractCode { get; set; }

    public int? ContractVersion { get; set; }

    public string? Note { get; set; }

    public double? Tax { get; set; }

    public double? Commission { get; set; }

    /// <summary>
    /// CHIẾT KHẤU
    /// </summary>
    public double? CustomFee { get; set; }

    /// <summary>
    /// GIẢM GIÁ
    /// </summary>
    public double? Discount { get; set; }

    public string? PriceType { get; set; }

    public string? ProductType { get; set; }

    public decimal? QuantityNeedExport { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? Currency { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
