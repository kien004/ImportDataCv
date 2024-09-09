using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectFile
{
    public int Id { get; set; }

    public string? ProjectCode { get; set; }

    public string? FileCode { get; set; }
}
