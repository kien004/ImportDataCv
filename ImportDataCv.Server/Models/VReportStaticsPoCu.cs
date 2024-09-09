using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VReportStaticsPoCu
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ProductType { get; set; }

    public double? RevenueAfterTaxVnd { get; set; }

    public string? ContractCode { get; set; }

    public string? Title { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? ContractNo { get; set; }

    public string? CusCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? CusName { get; set; }
}
