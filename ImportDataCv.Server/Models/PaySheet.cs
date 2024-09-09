using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PaySheet
{
    public int Id { get; set; }

    public string? PayGradesCode { get; set; }

    public string? PayGradesGroup { get; set; }

    public string? PayScale { get; set; }

    public int? PayRanges { get; set; }

    public decimal? PayCoef { get; set; }

    public decimal? BasicPay { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? PayGradesName { get; set; }
}
