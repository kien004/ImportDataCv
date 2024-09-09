using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FundRelativeObjMng
{
    public int Id { get; set; }

    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    public string? TickRecptPayCode { get; set; }

    public string? Relative { get; set; }
}
