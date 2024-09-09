using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetImprovementFile
{
    public int Id { get; set; }

    public string? FileCode { get; set; }

    public string? FileName { get; set; }

    public string? TicketCode { get; set; }
}
