using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRackDocument
{
    public int Id { get; set; }

    public string? RackCode { get; set; }

    public string? QrCode { get; set; }

    public string? RSize { get; set; }

    public string? Material { get; set; }

    public string? CntCell { get; set; }

    public string? RStatus { get; set; }

    public string? Note { get; set; }

    public int? CntBox { get; set; }

    public string? LineCode { get; set; }

    public string? RackName { get; set; }

    public string? Ordering { get; set; }
}
