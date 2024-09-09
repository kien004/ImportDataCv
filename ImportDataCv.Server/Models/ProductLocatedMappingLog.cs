using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductLocatedMappingLog
{
    public int Id { get; set; }

    public int? IdImpProduct { get; set; }

    public int? IdLocMapOld { get; set; }

    public int? IdLocatedMapping { get; set; }

    public string? MappingCodeOld { get; set; }

    public string? MappingCode { get; set; }

    public string? StoreCode { get; set; }

    public string? GattrCode { get; set; }

    public string? TicketCode { get; set; }

    public string? Type { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductNo { get; set; }

    public string? ProductQrCode { get; set; }

    public bool IsDeleted { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletionToken { get; set; }
}
