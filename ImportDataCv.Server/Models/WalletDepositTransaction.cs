using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WalletDepositTransaction
{
    public int Id { get; set; }

    public string? TransactionCode { get; set; }

    public string? TransactionType { get; set; }

    public string? Type { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public string? TransactionLog { get; set; }

    public string? Status { get; set; }

    public decimal? Coin { get; set; }

    public decimal? Ip { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
