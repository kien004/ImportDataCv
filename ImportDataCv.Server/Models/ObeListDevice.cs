using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ObeListDevice
{
    public int Id { get; set; }

    public string DeviceId { get; set; } = null!;

    public string? DeviceTitle { get; set; }

    public string? Vendor { get; set; }

    public string? PositionDevice { get; set; }

    public string? Account { get; set; }

    public string? Describe { get; set; }

    public string? DeviceType { get; set; }

    public int Status { get; set; }
}
