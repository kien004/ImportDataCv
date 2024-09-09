using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoSaleHeader
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ContractHeaderId { get; set; }

    public string? ContractCode { get; set; }

    public string? Title { get; set; }

    public string? ContractType { get; set; }

    public DateTime? ContractDate { get; set; }

    public string? ContractNo { get; set; }

    public string? Duration { get; set; }

    public int? Version { get; set; }

    public string? Status { get; set; }

    public string? Signer { get; set; }

    public string? MainService { get; set; }

    public decimal? Budget { get; set; }

    public string? Currency { get; set; }

    public string? LocationHardCopy { get; set; }

    public string? Describe { get; set; }

    public string? CusCode { get; set; }

    public string? ContractRelative { get; set; }

    public string? Tags { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? RealBudget { get; set; }

    public string? Confirm { get; set; }

    public DateTime? EstimateTime { get; set; }

    public string? LogProductDetail { get; set; }

    public string? PrjCode { get; set; }

    public decimal? BudgetExcludeTax { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? ExchangeRate { get; set; }

    public DateTime? AcceptanceTime { get; set; }

    public int? Maintenance { get; set; }

    public string? LogData { get; set; }

    public decimal? Commission { get; set; }

    public decimal? Discount { get; set; }

    public decimal? LastBudget { get; set; }

    public bool? IsChangeProduct { get; set; }

    public string? ListUserView { get; set; }

    public string? WorkflowCat { get; set; }

    public string? JsonData { get; set; }

    public string? StatusObject { get; set; }

    public string? StatusObjectLog { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
