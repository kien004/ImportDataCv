using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WhsZoneStruct
{
    public int Id { get; set; }

    public string? ZoneCode { get; set; }

    public string? ZoneName { get; set; }

    public string? ZoneLabel { get; set; }

    public int? ZoneLevel { get; set; }

    public string? ZoneParent { get; set; }

    public string? ZoneHierachy { get; set; }

    public string? ZoneType { get; set; }

    public string? ZoneGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? SvgIconData { get; set; }

    public string? Image { get; set; }

    public string? ShapeData { get; set; }
}
