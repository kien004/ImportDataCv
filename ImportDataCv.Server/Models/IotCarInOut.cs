using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class IotCarInOut
{
    public int Id { get; set; }

    public string? LicensePlate { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Active { get; set; }

    public string? Driver { get; set; }

    public string? Img1 { get; set; }

    public string? Img2 { get; set; }

    public string? Img3 { get; set; }

    public DateTime? ConfirmTime { get; set; }
}
