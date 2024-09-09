using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomDelivertHeader
{
    public int Id { get; set; }

    public string? DeliveryCode { get; set; }

    public string? DelivertyTitle { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerTitle { get; set; }

    public string? ExportTicketCode { get; set; }

    public string? Status { get; set; }

    public string? LocationTxt { get; set; }

    public string? LocationGps { get; set; }

    public DateTime? DeliveryTime { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }
}
