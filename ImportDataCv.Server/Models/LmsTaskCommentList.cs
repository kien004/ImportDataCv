using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsTaskCommentList
{
    public int Id { get; set; }

    public string? LmsTaskCode { get; set; }

    public string? CmtId { get; set; }

    public string? CmtContent { get; set; }

    public string? MemberId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool Flag { get; set; }
}
