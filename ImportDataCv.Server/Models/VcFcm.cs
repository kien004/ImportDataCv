using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcFcm
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string UserName { get; set; } = null!;
}
