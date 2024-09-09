using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WalletCoinExchange
{
    public int Id { get; set; }

    public string? Money { get; set; }

    public string? Currency { get; set; }

    public string? Coin { get; set; }

    public string? ExchangeLog { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
