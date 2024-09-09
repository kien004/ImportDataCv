using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CompanyRuleItem
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public string? Item { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateBy { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public bool? Flag { get; set; }
}
