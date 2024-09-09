using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductQrCode
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public string? LotCode { get; set; }

    public string? ImpCode { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int Count { get; set; }

    public string? QrCode { get; set; }

    /// <summary>
    /// SP hay SP trong kho(lô, phiếu nhập)
    /// </summary>
    public string? Type { get; set; }

    public string? JsonLog { get; set; }

    public bool? Enable { get; set; }
}
