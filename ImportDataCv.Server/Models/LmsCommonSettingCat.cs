using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsCommonSettingCat
{
    public int Id { get; set; }

    public string? AttrCode { get; set; }

    public string? AttrName { get; set; }

    public string? AttrNote { get; set; }

    public int? Group { get; set; }

    public string? Type { get; set; }

    public string? DataType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }

    public int? Order { get; set; }
}
