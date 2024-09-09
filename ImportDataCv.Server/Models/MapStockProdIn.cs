using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MapStockProdIn
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public string? ProdCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public int? ParentId { get; set; }

    public bool? IsDeleted { get; set; }
}
