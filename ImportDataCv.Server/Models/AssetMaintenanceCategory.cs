using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetMaintenanceCategory
{
    public int CategoryId { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryName { get; set; }

    public int? Quantity { get; set; }

    public long? Price { get; set; }

    public string? StatusCategory { get; set; }

    public string? NoteCategory { get; set; }

    public string? AssetCodeCategory { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public long? TotalMoneyCategory { get; set; }

    public string? UserCategory { get; set; }

    public string? TicketCodeCategory { get; set; }

    public string? Currency { get; set; }
}
