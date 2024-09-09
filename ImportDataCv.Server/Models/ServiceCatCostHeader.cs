using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ServiceCatCostHeader
{
    public int Id { get; set; }

    public string? HeaderCode { get; set; }

    public string? Title { get; set; }

    public DateTime EffectiveDate { get; set; }

    public DateTime ExpiryDate { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? Status { get; set; }

    public string? ResponsibleUser { get; set; }
}
