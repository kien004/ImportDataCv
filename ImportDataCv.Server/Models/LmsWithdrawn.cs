using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsWithdrawn
{
    public int Id { get; set; }

    public string? WithdrawCode { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public string? Noted { get; set; }

    public string? UserRequest { get; set; }

    public DateTime? RequestTime { get; set; }

    public string? FromIp { get; set; }

    public string? FromDevice { get; set; }

    public string? PaymentType { get; set; }

    public string? TransactionLog { get; set; }

    public string? Status { get; set; }

    public string? UserPay { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
