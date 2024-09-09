using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class NodeInfo
{
    public int Id { get; set; }

    public string? NodeCode { get; set; }

    public string? NodeName { get; set; }

    public string? Address { get; set; }

    public string? MarkerGps { get; set; }

    public string? PolygonGps { get; set; }

    public string? Province { get; set; }

    public string? Ward { get; set; }

    public string? District { get; set; }

    public string? Image { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
