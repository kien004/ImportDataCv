using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PriceQuoteDetail
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string? ProductCode { get; set; }

    public string? GattrCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public string? ProductType { get; set; }

    public decimal? Total { get; set; }

    public string? SupCode { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Currency { get; set; }

    public decimal? QuantitySupplies { get; set; }

    public decimal? DesiredPrice { get; set; }

    public DateTime? ExpectedDate { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public decimal? ExchangeRate { get; set; }
}
