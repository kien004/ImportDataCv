using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoBuyerHeaderPayment
{
    public int Id { get; set; }

    public string? BuyerCode { get; set; }

    public string? SupCode { get; set; }

    public string? PoTitle { get; set; }

    public string? PoSupCode { get; set; }

    public DateTime? DateOfOrder { get; set; }

    public string? OrderBy { get; set; }

    public string? Email { get; set; }

    public string? PaymentTerm { get; set; }

    public string? ShippingAdd { get; set; }

    public string? Consigner { get; set; }

    public string? Mobile { get; set; }

    public string? Buyer { get; set; }

    public string? Noted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Confirm { get; set; }

    public string? Status { get; set; }

    public DateOnly? EstimateTime { get; set; }

    public string? Type { get; set; }

    public string? Currency { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? ContractCode { get; set; }

    public string? ProjectCode { get; set; }

    public string? ListUserView { get; set; }

    public string? WorkflowCat { get; set; }

    public string? JsonData { get; set; }

    public string? StatusLog { get; set; }

    public string? StatusObject { get; set; }

    public string? StatusObjectLog { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalPayment { get; set; }
}
