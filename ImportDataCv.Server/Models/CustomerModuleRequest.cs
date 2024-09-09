using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CustomerModuleRequest
{
    public int Id { get; set; }

    public string ReqCode { get; set; } = null!;

    public string ModuleCode { get; set; } = null!;

    public string? Status { get; set; }
}
