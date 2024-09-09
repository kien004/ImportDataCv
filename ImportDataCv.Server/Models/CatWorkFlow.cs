using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CatWorkFlow
{
    public string? WorkFlowCode { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public int Id { get; set; }

    public string? Type { get; set; }
}
