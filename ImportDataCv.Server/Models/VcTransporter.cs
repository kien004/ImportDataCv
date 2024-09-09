using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcTransporter
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int? DriverId { get; set; }

    public string? LicensePlate { get; set; }

    public string? Generic { get; set; }

    public string? Group { get; set; }

    public string? Image { get; set; }

    public string? Name { get; set; }

    public string? Origin { get; set; }

    public string? CompanyCode { get; set; }

    public string? OwnerCode { get; set; }

    public int? Number { get; set; }

    public int? YearManufacture { get; set; }

    public string? Category { get; set; }

    public int? WeightItself { get; set; }

    public int? DesignPayload { get; set; }

    public int? PayloadPulled { get; set; }

    public int? PayloadTotal { get; set; }

    public string? SizeRegistry { get; set; }

    public string? SizeUse { get; set; }

    public string? RegistryDuration { get; set; }

    public string? InsurranceDuration { get; set; }

    public string? Note { get; set; }

    public string? PositionGps { get; set; }

    public string? PositionText { get; set; }

    public int? SumDistance { get; set; }

    public string? RomoocCode { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? CustomType { get; set; }

    public bool? IsDeleted { get; set; }

    public int? VehicleId { get; set; }

    public string? CustomerId { get; set; }

    public string? TransportMethodId { get; set; }

    public int? OrgId { get; set; }

    public string? DriverName { get; set; }

    public string? DriverInfo { get; set; }

    public string? ActiveFlag { get; set; }

    public string? UserNameDriver { get; set; }

    public string? LocationGps { get; set; }
}
