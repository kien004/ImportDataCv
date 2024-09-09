using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocCurrentPosition
{
    public int Id { get; set; }

    public string? PositionGps { get; set; }

    public string? PositionParking { get; set; }

    public string? PositionText { get; set; }

    public DateTime? PositionTime { get; set; }

    public string? RemoocCode { get; set; }

    public bool Status { get; set; }

    public string? TractorCode { get; set; }

    public string? TripCode { get; set; }

    public int? DriverId { get; set; }
}
