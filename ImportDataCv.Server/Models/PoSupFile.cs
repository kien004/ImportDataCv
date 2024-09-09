using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoSupFile
{
    public int Id { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? FileType { get; set; }

    public string? Noted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }
}
