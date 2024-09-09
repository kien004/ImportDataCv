using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProdPackageDelivery
{
    public int Id { get; set; }

    public string? CoilCode { get; set; }

    public decimal? Size { get; set; }

    public decimal? Remain { get; set; }

    public string? PositionInStore { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? TicketCode { get; set; }

    public string? CoilRelative { get; set; }

    public string? PackType { get; set; }

    public string? ProductQrCode { get; set; }

    public string? RackCode { get; set; }

    public string? RackPosition { get; set; }

    public string? TicketExpCode { get; set; }

    public string? ProductLot { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductType { get; set; }
}
