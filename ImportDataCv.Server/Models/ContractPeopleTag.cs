using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ContractPeopleTag
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ContractPeopleTagId { get; set; }

    public string? ContractCode { get; set; }

    public string? Assigner { get; set; }

    public DateTime? RequestTime { get; set; }

    public string? Confirm { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public string? TagsType { get; set; }

    public bool? Flags { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
