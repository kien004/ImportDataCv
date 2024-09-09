using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CardSubitemCheck
{
    public int Id { get; set; }

    public string? ChkListCode { get; set; }

    public string? Title { get; set; }

    public decimal Completed { get; set; }

    public DateTime? CompletedTime { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? Deadline { get; set; }

    public string? LocationText { get; set; }

    public string? LocationGps { get; set; }

    public string? Device { get; set; }

    public DateTime? BeginTime { get; set; }

    public decimal WeightNum { get; set; }

    public bool Approve { get; set; }

    public string? Approver { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public bool Flag { get; set; }
}
