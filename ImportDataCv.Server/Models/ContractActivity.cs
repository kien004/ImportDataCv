using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ContractActivity
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ContractActivityId { get; set; }

    public string? ActivityCode { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ContractCode { get; set; }

    public int? Version { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
