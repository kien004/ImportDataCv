using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SubWorkflowInstance
{
    public int Id { get; set; }

    public string? WfInstCode { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectCode { get; set; }

    public string? ActInstInitial { get; set; }

    public bool? IsMain { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
