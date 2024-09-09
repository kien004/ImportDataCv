using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class InspectionBeforeWarehouseHeader
{
    public int Id { get; set; }

    public string? ReviewCode { get; set; }

    public string? Title { get; set; }

    public string? Session { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? DocumentCode { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? Weight { get; set; }

    public string? SteelGrade { get; set; }

    public string? PackinglistNumber { get; set; }

    public decimal? Quantity { get; set; }

    public string? Specifications { get; set; }

    public string? Supplier { get; set; }

    public string? NumberOfOven { get; set; }

    public string? TypeOfMaterials { get; set; }

    public string? CheckTheSample { get; set; }

    public string? MassProduction { get; set; }

    public string? Inspector { get; set; }

    public DateTime? ImplementationDate { get; set; }

    public string? Endorsement { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public string? ApprovalPerson { get; set; }

    public DateTime? DateOfApproval { get; set; }

    public string? Quality { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool IsDeleted { get; set; }
}
