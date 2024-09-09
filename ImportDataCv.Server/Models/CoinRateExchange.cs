using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CoinRateExchange
{
    public int Id { get; set; }

    public string? Money { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? TimeUpdated { get; set; }
}
