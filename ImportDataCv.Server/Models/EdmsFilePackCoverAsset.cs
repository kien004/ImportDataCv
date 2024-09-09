using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsFilePackCoverAsset
{
    public int Id { get; set; }

    public string? FileCode { get; set; }

    public string? ObjPackCode { get; set; }

    public string? RackCode { get; set; }

    public string? RackPosition { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
