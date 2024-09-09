using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WalletCoinTransaction
{
    public int Id { get; set; }

    public string? TransactionCode { get; set; }

    public string? TransactionType { get; set; }

    public decimal? Coin { get; set; }

    public string? ItemType { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public string? Type { get; set; }

    public string? TransactionCoinLog { get; set; }

    public string? Status { get; set; }

    public string? Buyer { get; set; }

    public string? Seller { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
