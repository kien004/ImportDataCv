using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdParameter
{
    public decimal ParameterId { get; set; }

    public string ParameterCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ParentCode { get; set; }

    public string? Value { get; set; }

    public string? Value2 { get; set; }

    public string? Value3 { get; set; }

    public string? Value4 { get; set; }

    public string? Value5 { get; set; }
}
