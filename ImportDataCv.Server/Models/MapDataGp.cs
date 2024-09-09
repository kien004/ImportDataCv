using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MapDataGp
{
    public int Id { get; set; }

    public string? MapCode { get; set; }

    public string? MakerGps { get; set; }

    public string? PolygonGps { get; set; }

    public string? Title { get; set; }

    public string? Icon { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? Image { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDefault { get; set; }

    public string? GisData { get; set; }

    public string? Address { get; set; }
}
