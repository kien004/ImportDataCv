using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class JcObjectIdRelative100k
{
    public int Id { get; set; }

    public string? ObjTypeCode { get; set; }

    public string? ObjId { get; set; }

    public string? Relative { get; set; }

    public string? CardCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public decimal? Weight { get; set; }
}
