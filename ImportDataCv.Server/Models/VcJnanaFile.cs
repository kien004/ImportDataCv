using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcJnanaFile
{
    public int Id { get; set; }

    public string? FileCode { get; set; }

    public string? FileName { get; set; }

    public string? FileTitle { get; set; }

    public string? FileNote { get; set; }

    public double? FileSize { get; set; }

    public string? FileExt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? FileStatus { get; set; }

    public string? FileCatCode { get; set; }

    public string? FilePath { get; set; }

    public int? UpdatedBy { get; set; }
}
