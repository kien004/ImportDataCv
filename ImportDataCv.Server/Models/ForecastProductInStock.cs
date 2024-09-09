using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ForecastProductInStock
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public int? CntProductInStock { get; set; }

    public int? CntForecast { get; set; }

    public DateOnly? ForecastDate { get; set; }

    public string? ProductType { get; set; }

    public int? Cnt { get; set; }

    public int? Cnt2 { get; set; }
}
