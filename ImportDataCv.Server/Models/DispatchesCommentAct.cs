using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DispatchesCommentAct
{
    public int Id { get; set; }

    public string? ProcessCode { get; set; }

    public string? Comment { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreatedTime { get; set; }
}
