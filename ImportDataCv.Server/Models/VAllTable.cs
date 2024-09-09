using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAllTable
{
    public Guid? Id { get; set; }

    public string TableName { get; set; } = null!;
}
