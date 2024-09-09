using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductInPallet
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public int? IdImpProduct { get; set; }

    public string? ProductNo { get; set; }

    public string? GattrCode { get; set; }

    public string? StoreCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletionToken { get; set; }

    public bool IsDeleted { get; set; }

    public string? PackCode { get; set; }

    public decimal? Measure { get; set; }

    public int? IdLoadingTicket { get; set; }
}
