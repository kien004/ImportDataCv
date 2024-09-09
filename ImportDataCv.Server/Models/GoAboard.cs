using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class GoAboard
{
    public int Id { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string? Contact { get; set; }

    public string? Country { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
