using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocFcmMessage
{
    public int Id { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Message { get; set; }

    public string? Title { get; set; }

    public int Type { get; set; }

    public int UserId { get; set; }
}
