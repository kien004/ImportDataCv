using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkUserEvent
{
    public int Id { get; set; }

    public string? EventCatCode { get; set; }

    public string? MemberId { get; set; }

    public string? Present { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool Flag { get; set; }
}
