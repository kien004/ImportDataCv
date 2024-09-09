using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocTracking
{
    public int Id { get; set; }

    public int? DriverId { get; set; }

    public string? EndPositionGps { get; set; }

    public string? EndPositionCode { get; set; }

    public string? EndPositionText { get; set; }

    public DateTime? EndPositionTime { get; set; }

    public string? Note { get; set; }

    public string? RemoocCode { get; set; }

    public string? StartPositionGps { get; set; }

    public string? StartPositionCode { get; set; }

    public string? StartPositionText { get; set; }

    public DateTime? StartPositionTime { get; set; }

    public string? TractorCode { get; set; }

    public string? TripCode { get; set; }

    public string? CompanyCode { get; set; }

    public string? ContainerCode { get; set; }

    public string? Imgcontain1 { get; set; }

    public string? Imgcontain2 { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Status { get; set; }

    public string? InitPositionText { get; set; }

    public DateTime? InitPositionTime { get; set; }

    public string? TypeTrip { get; set; }

    public string? MaTheoDoi { get; set; }

    public string? Band { get; set; }

    public string? CurrentPositionText { get; set; }

    public string? CurrentPositionGps { get; set; }

    public string? InitPositionGps { get; set; }

    public string? InitPositionCode { get; set; }
}
