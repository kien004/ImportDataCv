using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ServiceRegist
{
    public int Id { get; set; }

    public string? ServiceCode { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectCode { get; set; }

    public DateTime? BeginTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Status { get; set; }

    public string? PaymentStatus { get; set; }

    public string? ServiceType { get; set; }

    public string? LogPay { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? LogAction { get; set; }

    public string? Note { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
