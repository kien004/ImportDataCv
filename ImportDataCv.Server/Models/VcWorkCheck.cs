using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcWorkCheck
{
    public int Id { get; set; }

    public DateTime? CheckinTime { get; set; }

    public bool? Checkin { get; set; }

    public bool? Checkout { get; set; }

    public DateTime? CheckoutTime { get; set; }

    public string? CareCode { get; set; }

    public string? CreatedBy { get; set; }

    public string? Review { get; set; }

    public string? Idea { get; set; }

    public string? Address { get; set; }

    public string? CheckinGps { get; set; }

    public string? CheckoutGps { get; set; }

    public string? UserName { get; set; }

    public string? Imei { get; set; }

    public string? ImagePath { get; set; }

    public int Count { get; set; }

    public bool? CheckoutOutDistance { get; set; }
}
