using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ContractDetail
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ContractDetailId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal Quatity { get; set; }

    public string? Unit { get; set; }

    public decimal Cost { get; set; }

    public string? ContractCode { get; set; }

    public int? ContractVersion { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
