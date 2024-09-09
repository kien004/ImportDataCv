using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SwModuleResource
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string ModuleCode { get; set; } = null!;

    public string ModuleTitle { get; set; } = null!;

    public string? Description { get; set; }

    public int? Level { get; set; }

    public string? ParentModule { get; set; }

    public DateTime CreatedTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }
}
