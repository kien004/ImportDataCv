using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CmsTag
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Published { get; set; }
}
