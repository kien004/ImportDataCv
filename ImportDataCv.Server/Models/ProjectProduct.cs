using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectProduct
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? ProjectCode { get; set; }

    public decimal Cost { get; set; }

    public double Tax { get; set; }

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

    public string? Note { get; set; }

    public string? PortType { get; set; }

    public string? StatusObjectLog { get; set; }
}
