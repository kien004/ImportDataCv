using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoolMemberNotification
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int NotifyId { get; set; }

    public string? Assigner { get; set; }

    public DateTime? AssignerTime { get; set; }

    public string? Assignee { get; set; }

    public DateTime? AssigneeTime { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public string? ModuleName { get; set; }

    public string? Title { get; set; }

    public string? Link { get; set; }
}
