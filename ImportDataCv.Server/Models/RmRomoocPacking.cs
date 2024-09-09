using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocPacking
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? GisData { get; set; }

    public string? Image { get; set; }

    public string? Owner { get; set; }

    public string? Title { get; set; }

    public string? CompanyCode { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public int Flag { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Address { get; set; }

    public string? Icon { get; set; }
}
