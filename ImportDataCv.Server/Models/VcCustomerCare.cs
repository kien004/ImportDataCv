using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcCustomerCare
{
    public int Id { get; set; }

    public string CareCode { get; set; } = null!;

    public string RouteCode { get; set; } = null!;

    public string BrandCode { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public decimal? BuyCost { get; set; }

    public decimal? SaleCost { get; set; }

    public decimal? ConsumpMonthly { get; set; }

    public decimal? Instock { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public int? IdWorkCheck { get; set; }
}
