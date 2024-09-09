using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PackageTicketHd
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? TicketTitle { get; set; }

    public string? TicketCreator { get; set; }

    public DateTime? TicketTimeCreator { get; set; }

    public string? Packager { get; set; }

    public DateTime? PackagerTime { get; set; }

    public string? Status { get; set; }

    public string? Noted { get; set; }
}
