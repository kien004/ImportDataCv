using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ZoneDevicePlacement
{
    public int Id { get; set; }

    public string? DeviceCode { get; set; }

    public string? ZoneCode { get; set; }

    public string? Position { get; set; }

    public string? Status { get; set; }

    public DateTime? BeginTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? ManagerId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
