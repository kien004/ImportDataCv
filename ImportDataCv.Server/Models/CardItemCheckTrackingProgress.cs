using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CardItemCheckTrackingProgress
{
    public int Id { get; set; }

    public string? ItemCode { get; set; }

    public int Completed { get; set; }

    public DateTime? CompletedTime { get; set; }
}
