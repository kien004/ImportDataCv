using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRequestEndBox
{
    public int Id { get; set; }

    public string? RqCode { get; set; }

    public string? BoxCode { get; set; }
}
