using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SupplierFile
{
    public int Id { get; set; }

    public int? SupplierId { get; set; }

    public string? FileCode { get; set; }
}
