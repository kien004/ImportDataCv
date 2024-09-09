using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BomDeliveryHeader
{
    public int Id { get; set; }

    public string? DeliveryCode { get; set; }

    public string? DeliveryTitle { get; set; }

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

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? JsonStatus { get; set; }
}
