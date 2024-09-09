using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CylinkerFuelLoadingDt
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? TankCode { get; set; }

    public string? CylinkerCode { get; set; }

    public decimal? Volume { get; set; }

    public string? Unit { get; set; }
}
