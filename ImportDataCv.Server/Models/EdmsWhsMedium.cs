using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsWhsMedium
{
    public int Id { get; set; }

    public string? FileCode { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? FileExt { get; set; }

    public string? FileSite { get; set; }

    public string? Note { get; set; }
}
