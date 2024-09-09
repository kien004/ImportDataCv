using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MaterialStore
{
    public int StoreId { get; set; }

    public string? StoreCode { get; set; }

    public string? StoreName { get; set; }

    public string? Description { get; set; }

    public int? Flag { get; set; }

    public string? Location { get; set; }

    public string? UserId { get; set; }

    public int? Province { get; set; }

    public int? District { get; set; }

    public int? Ward { get; set; }

    public int? BranchId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? Area { get; set; }

    public string? Status { get; set; }

    public string? Extend { get; set; }

    public string? Type { get; set; }

    public int? CountFloor { get; set; }

    public string? QrCode { get; set; }
}
