using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VCardProcess
{
    public Guid? Id { get; set; }

    public string? CardCode { get; set; }

    public decimal WeightNum { get; set; }

    public int? Month { get; set; }

    public decimal? Progress { get; set; }

    public string? BoardCode { get; set; }

    public int? Year { get; set; }

    public string? ObjId { get; set; }
}
