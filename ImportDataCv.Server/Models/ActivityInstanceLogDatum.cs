using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ActivityInstanceLogDatum
{
    public int Id { get; set; }

    public string? ActCode { get; set; }

    public string? WorkFlowCode { get; set; }

    public string? ObjCode { get; set; }

    public DateTime? ActTime { get; set; }

    public decimal? ActLocationGps { get; set; }

    public string? ActFromDevice { get; set; }

    public string? ActType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Log { get; set; }
}
