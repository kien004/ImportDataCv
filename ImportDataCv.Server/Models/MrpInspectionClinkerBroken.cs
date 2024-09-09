using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpInspectionClinkerBroken
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? Serial { get; set; }

    public string? Origin { get; set; }

    public string? TechStatus { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
