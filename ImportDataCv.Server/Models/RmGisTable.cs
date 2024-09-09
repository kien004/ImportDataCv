using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmGisTable
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Parent { get; set; }

    public string? Type { get; set; }

    public string? NodeGis { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }
}
