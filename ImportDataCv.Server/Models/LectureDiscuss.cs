using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LectureDiscuss
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Comment { get; set; }

    public string? RefLst { get; set; }

    public int? ParentId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
