using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CustomerFile
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? FileCode { get; set; }
}
