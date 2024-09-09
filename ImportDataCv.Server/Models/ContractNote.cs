using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ContractNote
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ContractNoteId { get; set; }

    public string? ContractCode { get; set; }

    public int? ContractVersion { get; set; }

    public string? Note { get; set; }

    public string? Title { get; set; }

    public string? Tags { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
