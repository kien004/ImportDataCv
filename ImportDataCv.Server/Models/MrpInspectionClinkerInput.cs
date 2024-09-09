using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpInspectionClinkerInput
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? ClinkerType { get; set; }

    public decimal? NumSuggest { get; set; }

    public decimal? NumInput { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
