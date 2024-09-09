using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ActivityWorkflow
{
    public int Id { get; set; }

    public string? ActCode { get; set; }

    public string? ActName { get; set; }

    public string? ActParent { get; set; }

    public string? ActNoted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ActAttributeGraph { get; set; }

    public string? ActStatus { get; set; }
}
