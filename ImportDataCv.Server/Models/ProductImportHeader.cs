using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductImportHeader
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? LotProductCode { get; set; }

    public string? CusCode { get; set; }

    public string? SupCode { get; set; }

    public string? StoreCode { get; set; }

    public string? Title { get; set; }

    public string? UserImport { get; set; }

    public string? UserSend { get; set; }

    public string? AuditTicketCode { get; set; }

    public string? ExpTicketCode { get; set; }

    public string? GroupType { get; set; }

    public decimal? CostTotal { get; set; }

    public string? Currency { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Commission { get; set; }

    public decimal? TaxTotal { get; set; }

    public string? Note { get; set; }

    public string? PositionGps { get; set; }

    public string? PositionText { get; set; }

    public string? FromDevice { get; set; }

    public decimal? TotalPayed { get; set; }

    public decimal? TotalMustPayment { get; set; }

    public DateTime? InsurantTime { get; set; }

    public DateTime? TimeTicketCreate { get; set; }

    public DateTime? NextTimePayment { get; set; }

    public string? Reason { get; set; }

    public string? StoreCodeSend { get; set; }

    public string? PaymentStatus { get; set; }

    public string? LogData { get; set; }

    public string? Status { get; set; }

    public string? WorkflowCat { get; set; }

    public string? JsonData { get; set; }

    public string? SrcData { get; set; }

    public string? JsonStatus { get; set; }

    public bool? IsBom { get; set; }

    public string? ActInstCode { get; set; }

    public string? Io { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletionToken { get; set; }

    public bool IsDeleted { get; set; }
}
