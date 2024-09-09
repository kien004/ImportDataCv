using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsMentorMentee
{
    public int Id { get; set; }

    public string? MentorCode { get; set; }

    public string? MenteeCode { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public int? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
