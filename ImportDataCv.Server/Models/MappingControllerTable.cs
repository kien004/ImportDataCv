using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MappingControllerTable
{
    public int Id { get; set; }

    public string? Controller { get; set; }

    public string? Action { get; set; }

    public string? Table { get; set; }
}
