using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PackageObject
{
    public int Id { get; set; }

    public string? PackCode { get; set; }

    public string? PackName { get; set; }

    public string? PackType { get; set; }

    public string? Specs { get; set; }

    public string? Noted { get; set; }

    public string? CurrentPos { get; set; }

    public string? Status { get; set; }

    public string? PackCodeParent { get; set; }

    public string? AttrPack { get; set; }

    public string? Level { get; set; }

    public string? NumPosition { get; set; }

    public string? StatusReady { get; set; }

    public string? PackLot { get; set; }
}
