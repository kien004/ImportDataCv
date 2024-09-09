using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdAppFunction
{
    public string? ApplicationCode { get; set; }

    public string? FunctionCode { get; set; }

    public int AppFunctionId { get; set; }
}
