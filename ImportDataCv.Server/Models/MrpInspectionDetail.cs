using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpInspectionDetail
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? ProductCode { get; set; }

    public decimal? WeightCreated { get; set; }

    public decimal? WeightInspect { get; set; }

    public decimal? WeightWater { get; set; }

    public decimal? CapacityCreated { get; set; }

    public decimal? CapacityInspect { get; set; }

    public decimal? PressureTest { get; set; }

    public decimal? PressureWork { get; set; }

    public decimal? ExpansionValue { get; set; }

    public decimal? ExpansionRate { get; set; }

    public string? WeightUnit { get; set; }

    public string? CapacityUnit { get; set; }

    public string? PressureUnit { get; set; }

    public string? InnerInspection { get; set; }

    public string? OuterInspection { get; set; }

    public string? Conclusion { get; set; }

    public DateTime? ExpireDate { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ManufacturingDate { get; set; }

    public int? Quantity { get; set; }

    public string? Origin { get; set; }

    public string? Serial { get; set; }

    public DateTime? DateCreate { get; set; }
}
