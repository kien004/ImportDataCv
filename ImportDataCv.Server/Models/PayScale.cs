using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PayScale
{
    public int Id { get; set; }

    public string? PayScaleCode { get; set; }

    public decimal? PayBase { get; set; }

    public string? Unit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? CareerCode { get; set; }

    public string? CareerTitle { get; set; }

    public string? Certificate { get; set; }

    public string? Major { get; set; }
}
