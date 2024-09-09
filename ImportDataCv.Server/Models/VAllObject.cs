using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAllObject
{
    public Guid? Id { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public string ObjectType { get; set; } = null!;
}
