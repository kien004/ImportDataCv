using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RoadInfo
{
    public int Id { get; set; }

    public string? RoadCode { get; set; }

    public string? RoadName { get; set; }

    public string? RoadType { get; set; }

    public string? NodeList { get; set; }

    public decimal? Distance { get; set; }

    public string? Desc { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
