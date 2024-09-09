using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MobiFunctionJobcardList
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Value { get; set; }

    public string? Desc { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
