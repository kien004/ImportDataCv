using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRepoCatFile
{
    public int Id { get; set; }

    public string? FileCode { get; set; }

    public string? ReposCode { get; set; }

    public string? CatCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectType { get; set; }

    public string? Path { get; set; }

    public string? FolderId { get; set; }

    public string? ItemCode { get; set; }
}
