using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocTractor
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? DriverId { get; set; }

    public int? Flag { get; set; }

    public string? Generic { get; set; }

    public string? Group { get; set; }

    public string? Image { get; set; }

    public string? Name { get; set; }

    public string? Origin { get; set; }

    public string? CompanyCode { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? LicensePlate { get; set; }

    public int? Number { get; set; }

    public int? YearManufacture { get; set; }

    public string? OwnerCode { get; set; }

    public string? Category { get; set; }

    public int? WeightItself { get; set; }

    public int? DesignPayload { get; set; }

    public int? PayloadPulled { get; set; }

    public int? PayloadTotal { get; set; }

    public string? SizeRegistry { get; set; }

    public string? SizeUse { get; set; }

    public DateTime? RegistryDuration { get; set; }

    public DateTime? InsurranceDuration { get; set; }

    public string? Note { get; set; }

    public string? PositionGps { get; set; }

    public string? PositionText { get; set; }

    public int? SumDistance { get; set; }

    public string? RomoocCode { get; set; }
}
