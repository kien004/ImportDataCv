using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductPackMapping
{
    public int Id { get; set; }

    public string? PackCode { get; set; }

    public string? Position { get; set; }

    public string? Ordering { get; set; }

    public string? ProductQrCode { get; set; }

    public bool IsDeleted { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? TicketImpCode { get; set; }
}
