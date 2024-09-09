using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetTransferFile
{
    public int Id { get; set; }

    public string? Ticketcode { get; set; }

    public string? FileCode { get; set; }

    public string? FileName { get; set; }
}
