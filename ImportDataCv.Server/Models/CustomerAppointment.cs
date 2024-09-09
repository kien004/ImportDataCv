using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CustomerAppointment
{
    public int Id { get; set; }

    public string? CustomerCode { get; set; }

    public string? Note { get; set; }

    public string? Title { get; set; }

    public string? Tags { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Location { get; set; }

    public string? RepeatType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
