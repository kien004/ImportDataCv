using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class StockArrangePopEntry
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public string? ProdCode { get; set; }

    public decimal? Quantity { get; set; }

    public bool? MarkWholeProduct { get; set; }

    public string? UnitExp { get; set; }
}
