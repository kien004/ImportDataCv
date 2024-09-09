using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RecordsPack
{
    public int Id { get; set; }

    public string? PackCode { get; set; }

    public string? QrCode { get; set; }

    public string? PackName { get; set; }

    public string? PackLabel { get; set; }

    public string? PackLevel { get; set; }

    public string? PackParent { get; set; }

    public string? PackHierarchyPath { get; set; }

    public string? PackZoneLocation { get; set; }

    public string? PackType { get; set; }

    public string? PackGroup { get; set; }

    public string? PackStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public int? PackQuantity { get; set; }
}
