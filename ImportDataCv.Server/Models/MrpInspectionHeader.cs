using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpInspectionHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? KcsTitle { get; set; }

    public string? KcsExcuter { get; set; }

    public string? Customer { get; set; }

    public DateTime? KcsDate { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Receiver { get; set; }

    public DateTime? DeliveryDateEst { get; set; }

    public DateTime? DeliveryDateReal { get; set; }

    public string? KcsCode { get; set; }

    public string? StoreKeeper { get; set; }
}
