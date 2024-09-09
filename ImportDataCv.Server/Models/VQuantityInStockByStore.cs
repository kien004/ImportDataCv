using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VQuantityInStockByStore
{
    public string? ProductCode { get; set; }

    public string? ProductQrCode { get; set; }

    public string? StoreCode { get; set; }

    public decimal? TotalQuantityByStore { get; set; }

    public decimal? TotalQuantityInStore { get; set; }
}
