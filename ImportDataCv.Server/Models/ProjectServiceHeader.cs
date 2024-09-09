using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectServiceHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public int? TicketCount { get; set; }

    public string? Title { get; set; }

    public string? ProjectCode { get; set; }

    public string? Note { get; set; }

    public string? PortType { get; set; }

    public DateTime? TicketTime { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public string? Supplier { get; set; }

    public string? StatusObjectLog { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
