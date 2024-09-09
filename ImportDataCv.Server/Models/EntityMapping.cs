using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EntityMapping
{
    public int Id { get; set; }

    public string? PoSaleCode { get; set; }

    public string? PoBuyerCode { get; set; }

    public string? ReqCode { get; set; }

    public string? ProjectCode { get; set; }
}
