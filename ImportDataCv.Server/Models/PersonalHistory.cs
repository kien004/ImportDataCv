using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PersonalHistory
{
    public int Id { get; set; }

    public string? Begin { get; set; }

    public string? End { get; set; }

    public string? Content { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
