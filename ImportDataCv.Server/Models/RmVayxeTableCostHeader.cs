using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeTableCostHeader
{
    public int Id { get; set; }

    public string? TableCode { get; set; }

    public string? TableName { get; set; }

    public string? Note { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }

    public int? CreaterId { get; set; }

    public string? AppoverId { get; set; }

    public DateTime? BeginTimeApply { get; set; }

    public DateTime? EndTimeApply { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
