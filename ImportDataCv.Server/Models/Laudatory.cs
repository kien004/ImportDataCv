using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Laudatory
{
    public int Id { get; set; }

    public DateOnly? Time { get; set; }

    public string? Reason { get; set; }

    public string? GrantDecision { get; set; }
}
