using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class IotWarningSetting
{
    public int Id { get; set; }

    public string? ObjType { get; set; }

    public string? DeviceCode { get; set; }

    public decimal? CloseBelow { get; set; }

    public decimal? CloseOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? Location { get; set; }
}
