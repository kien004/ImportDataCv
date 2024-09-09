using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PackageTicketDt
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? ProductCode { get; set; }

    public int? IdImpProduct { get; set; }

    public string? ProductNumRange { get; set; }

    public string? GattrCode { get; set; }

    public string? PackCode { get; set; }

    public string? StatusProductPallet { get; set; }
}
