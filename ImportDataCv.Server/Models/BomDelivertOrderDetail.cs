using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomDelivertOrderDetail
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? Speaciticate { get; set; }

    public string? ItemStatus { get; set; }

    public string? DeliveryCode { get; set; }
}
