using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ContractMemberTask
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int Id { get; set; }

    public string? Assigner { get; set; }

    public DateTime? AssignerTime { get; set; }

    public string? Assignee { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public string? ContractCode { get; set; }

    public string? TaskCode { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
