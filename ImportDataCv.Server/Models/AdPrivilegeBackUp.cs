using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdPrivilegeBackUp
{
    public string? FunctionCode { get; set; }

    public string? ResourceCode { get; set; }

    public int PrivilegeId { get; set; }
}
