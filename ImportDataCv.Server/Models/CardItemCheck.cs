using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CardItemCheck
{
    public int Id { get; set; }

    public string? CardCode { get; set; }

    public string? CheckTitle { get; set; }

    public string? Status { get; set; }

    public string? MemberId { get; set; }

    public DateTime? Finishtime { get; set; }

    public string? ChkListCode { get; set; }

    public int Percent { get; set; }

    public decimal Completed { get; set; }

    public DateTime? CompletedTime { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? Deadline { get; set; }

    public string? LocationText { get; set; }

    public string? LocationGps { get; set; }

    public string? Device { get; set; }

    public DateTime? BeginTime { get; set; }

    public decimal WeightNum { get; set; }

    public bool Flag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? Constraint { get; set; }

    public string? WfInstCode { get; set; }

    public string? ActInstCode { get; set; }

    public string? Note { get; set; }
}
