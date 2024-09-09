using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoSupAttribute
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ContractAttributeId { get; set; }

    public string? PoSupCode { get; set; }

    public int? ContractVersion { get; set; }

    public string? AttrCode { get; set; }

    public string? AttrValue { get; set; }

    public string? AttrGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? Note { get; set; }
}
