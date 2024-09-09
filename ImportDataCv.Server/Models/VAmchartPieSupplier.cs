using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAmchartPieSupplier
{
    public Guid? Id { get; set; }

    public string? Status { get; set; }

    public string? Country { get; set; }

    public int? Litres { get; set; }
}
