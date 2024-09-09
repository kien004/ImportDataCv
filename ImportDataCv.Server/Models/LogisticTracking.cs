using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LogisticTracking
{
    public int Id { get; set; }

    public string? ShipmentCode { get; set; }

    public string? ActivityCode { get; set; }

    public string? LicensePlate { get; set; }

    public string? DriverInfo { get; set; }

    public string? AddressText { get; set; }

    public string? GpsData { get; set; }

    public DateTime? TimeActivity { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? PoB2bCode { get; set; }
}
