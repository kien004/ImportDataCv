using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PriceQuoteHeader
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string? Title { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Note { get; set; }

    public string? LogStatus { get; set; }

    public DateTime? ExpectedDate { get; set; }

    public DateTime? TimeTicketCreate { get; set; }

    public string? UserRequest { get; set; }

    public string? JsonStatus { get; set; }
}
