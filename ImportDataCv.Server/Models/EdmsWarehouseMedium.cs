using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsWarehouseMedium
{
    public int Id { get; set; }

    public string? WhsCode { get; set; }

    public string? FileCode { get; set; }
}
