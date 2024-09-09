using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomActivityAttr
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? DataType { get; set; }

    public string? ItemUnit { get; set; }

    public string? Note { get; set; }

    public string? WfInstCode { get; set; }

    public string? ActivityCode { get; set; }

    public string? Io { get; set; }

    public string? Postfix { get; set; }

    public string? Specification { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
