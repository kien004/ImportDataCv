using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsObjectShareFile
{
    public int Id { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectCode { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? Permission { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? FileCode { get; set; }

    public string? ObjectCodeShared { get; set; }

    public string? ObjectTypeShared { get; set; }
}
