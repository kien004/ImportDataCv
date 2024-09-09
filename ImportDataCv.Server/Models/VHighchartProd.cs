using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VHighchartProd
{
    public Guid? Id { get; set; }

    public int? Month { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Total { get; set; }
}
