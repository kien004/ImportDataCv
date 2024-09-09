using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class InventoryAuditHeader
{
    public int Id { get; set; }

    public string? AuditTicketCode { get; set; }

    public string? Title { get; set; }

    public DateTime? AuditFrom { get; set; }

    public DateTime? AuditTo { get; set; }

    public string? Status { get; set; }

    public string? Auditors { get; set; }

    public string? Note { get; set; }

    public string? InventoryCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
