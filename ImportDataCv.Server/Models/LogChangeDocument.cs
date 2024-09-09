using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LogChangeDocument
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? LogContent { get; set; }

    public DateTime? TimeEdit { get; set; }

    public DateTime? TimeFinish { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsEdited { get; set; }

    public string? FileName { get; set; }

    public string? FileCode { get; set; }

    public string? FileType { get; set; }

    public string? LogText { get; set; }

    public string? ObjCode { get; set; }

    public string? ObjType { get; set; }
}
