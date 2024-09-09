using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class OperatingVideoTrack
{
    public int Id { get; set; }

    public string? SessionCode { get; set; }

    public string? Po { get; set; }

    public string? Status { get; set; }

    public string? Path { get; set; }

    public string? VideoName { get; set; }

    public string? OperatingType { get; set; }

    public string? RecordDevice { get; set; }

    public string? Executer { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Note { get; set; }
}
