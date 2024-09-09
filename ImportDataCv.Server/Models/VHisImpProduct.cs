using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VHisImpProduct
{
    public Guid? Id { get; set; }

    public string? TicketImpCode { get; set; }

    public string? PoSupCode { get; set; }

    public string? SupCode { get; set; }

    public string? SupName { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductType { get; set; }

    public string? ProductQrCode { get; set; }

    public decimal? QuantityImp { get; set; }

    public string? Unit { get; set; }

    public string? UnitName { get; set; }

    public DateTime CreatedTime { get; set; }

    public decimal? SupPrice { get; set; }

    public string? Currency { get; set; }

    public string? CurrencyName { get; set; }

    public string? TicketExpCode { get; set; }

    public string? PoCusCode { get; set; }

    public string? CusCode { get; set; }

    public string? CusName { get; set; }

    public decimal? QuantityExp { get; set; }
}
