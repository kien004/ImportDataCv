using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsCommonSettingValue
{
    public int Id { get; set; }

    public string? AttrCode { get; set; }

    public string? AttrValue { get; set; }

    public string? Unit { get; set; }

    public string? TableName { get; set; }

    public string? ObjectCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }
}
