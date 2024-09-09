using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FilesShareObjectUser
{
    public int Id { get; set; }

    public string? FileId { get; set; }

    public string? ObjectRelative { get; set; }

    public string? FileCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FileUrl { get; set; }

    public string? FileName { get; set; }

    public string? ListUserShare { get; set; }
}
