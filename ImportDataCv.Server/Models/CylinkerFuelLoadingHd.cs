using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CylinkerFuelLoadingHd
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? TicketTitle { get; set; }

    public string? TicketCreator { get; set; }

    public DateTime? TicketCreatedTime { get; set; }

    public string? Loader { get; set; }

    public DateTime? LoaderTime { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }
}
