using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class IotDeviceInfo
{
    public int Id { get; set; }

    public string? DeviceCode { get; set; }

    public string? DeviceName { get; set; }

    public string? DeviceGroup { get; set; }

    public string? DeviceType { get; set; }

    public string? DeviceManufacturer { get; set; }

    public string? DeviceStatus { get; set; }

    public string? DeviceDesc { get; set; }

    public string? DeviceImage { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeviceSvg { get; set; }
}
