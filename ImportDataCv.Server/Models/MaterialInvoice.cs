using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MaterialInvoice
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Title { get; set; }

    public double? TotalPay { get; set; }

    public string? Currency { get; set; }

    public int? Type { get; set; }

    public string? Note { get; set; }

    public int? ContractId { get; set; }

    public int? Reason { get; set; }

    public DateTime? CreatedTime { get; set; }
}
