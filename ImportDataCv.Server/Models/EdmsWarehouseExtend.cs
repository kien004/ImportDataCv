using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsWarehouseExtend
{
    public int Id { get; set; }

    public string? ExtCode { get; set; }

    public string? WhsCode { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }

    public string? ExtValue { get; set; }

    public string? ExtGroup { get; set; }

    public bool? IsDeleted { get; set; }
}
