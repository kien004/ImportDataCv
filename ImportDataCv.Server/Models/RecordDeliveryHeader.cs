using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RecordDeliveryHeader
{
    public int Id { get; set; }

    public string? DeliveryCode { get; set; }

    public string? Title { get; set; }

    public string? DeliveryType { get; set; }

    public string? Note { get; set; }

    public string? DeliverCode { get; set; }

    public string? ReceiverName { get; set; }

    public string? Status { get; set; }

    public DateTime? ExpertedReturnDate { get; set; }

    public DateTime? RealReturnDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
