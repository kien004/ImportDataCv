using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RequestImpProductDetail
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string? ProductCode { get; set; }

    public string? PoCount { get; set; }

    public decimal? RateConversion { get; set; }

    public decimal? RateLoss { get; set; }

    public decimal? Quantity { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Unit { get; set; }

    public string? ProductType { get; set; }

    public string? SupCode { get; set; }

    public DateTime? ExpectedDate { get; set; }
}
