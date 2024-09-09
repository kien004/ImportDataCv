using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WarehouseZoneAttr
{
    public int Id { get; set; }

    public string? ZoneAttrCode { get; set; }

    public string? ZoneAttrName { get; set; }

    public string? ZoneAttrValue { get; set; }

    public string? ZoneAttrUnit { get; set; }

    public string? ZoneAttrType { get; set; }

    public string? ZoneAttrSize { get; set; }

    public string? ZoneType { get; set; }

    public string? ZoneGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? SvgIcon { get; set; }

    public string? Image { get; set; }
}
