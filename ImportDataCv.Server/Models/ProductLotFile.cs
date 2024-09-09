using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductLotFile
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public string? FileCode { get; set; }

    public string? Type { get; set; }
}
