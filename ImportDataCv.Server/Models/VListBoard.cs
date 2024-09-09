using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VListBoard
{
    public Guid? Id { get; set; }

    public string? BoardCode { get; set; }

    public string? BoardName { get; set; }
}
