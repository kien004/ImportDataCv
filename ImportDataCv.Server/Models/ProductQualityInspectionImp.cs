using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductQualityInspectionImp
{
    public int Id { get; set; }

    public string? QcTicketCode { get; set; }

    public string? TicketTitle { get; set; }

    public string? TicketCreator { get; set; }

    public DateTime? TicketCreateTime { get; set; }

    public string? Status { get; set; }

    public string? Excuter { get; set; }

    public string? Checker { get; set; }

    public string? Noted { get; set; }
}
