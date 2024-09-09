using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FundExchangeRate
{
    public int Id { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    /// <summary>
    /// 0
    /// </summary>
    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
