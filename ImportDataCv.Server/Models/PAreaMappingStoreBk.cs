using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PAreaMappingStoreBk
{
    public int Id { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectType { get; set; }

    public string? CategoryCode { get; set; }

    public string? SvgIconData { get; set; }

    public string? Image { get; set; }

    public string? WhsCode { get; set; }

    public string? ShapeData { get; set; }

    public string? JsonAttr { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
