using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class TablesToUpdate
{
    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public int? RecordsToUpdate { get; set; }
}
