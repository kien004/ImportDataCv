using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class StatusSetDetail
{
    public int Id { get; set; }

    public string? StatusCode { get; set; }

    public string? StatusName { get; set; }

    public string? StatusType { get; set; }

    public string? StatusGroup { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
