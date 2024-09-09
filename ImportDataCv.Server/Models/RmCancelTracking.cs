using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmCancelTracking
{
    public int Id { get; set; }

    public string? LocationGps { get; set; }

    public string? LocationText { get; set; }

    public string? ReasonCancel { get; set; }

    public string? TripCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ParkingCode { get; set; }

    public string? CreateBy { get; set; }

    public string? Note { get; set; }
}
