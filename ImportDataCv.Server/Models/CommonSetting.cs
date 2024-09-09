using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CommonSetting
{
    public int SettingId { get; set; }

    public string CodeSet { get; set; } = null!;

    public string? ValueSet { get; set; }

    public string? Group { get; set; }

    /// <summary>
    /// Asset_code ==null không được quản lý
    /// </summary>
    public string? AssetCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? GroupNote { get; set; }

    public int? Priority { get; set; }

    public string? Logo { get; set; }

    public string? Type { get; set; }

    public string? Title { get; set; }

    public string? Unit { get; set; }
}
