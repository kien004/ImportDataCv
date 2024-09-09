using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AseanDocument
{
    public int Id { get; set; }

    public string? FileCode { get; set; }

    public string? Title { get; set; }

    public string? Subdesc { get; set; }

    public string? FileType { get; set; }

    public int? Version { get; set; }

    public string? FileName { get; set; }

    public string? FileSite { get; set; }

    public string? FilePath { get; set; }

    public string? Description { get; set; }

    public int? ParentId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? CateCode { get; set; }

    public string? FullPathView { get; set; }

    public bool? IsEdited { get; set; }

    public string? ViewPath { get; set; }
}
