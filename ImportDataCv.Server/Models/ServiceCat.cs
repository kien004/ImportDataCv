using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ServiceCat
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ServiceCatId { get; set; }

    public string? ServiceCode { get; set; }

    public string? ServiceName { get; set; }

    public string? Unit { get; set; }

    public string? Note { get; set; }

    public string? ServiceGroup { get; set; }

    public string? ServiceType { get; set; }

    public string? ServiceParent { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public int? Visibility { get; set; }
}
