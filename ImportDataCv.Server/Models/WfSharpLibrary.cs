using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WfSharpLibrary
{
    public int Id { get; set; }

    public string? SharpCode { get; set; }

    public string? SharpName { get; set; }

    public string? SharpData { get; set; }

    public string? SharpType { get; set; }

    public string? SharpDesc { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? SharpPath { get; set; }
}
