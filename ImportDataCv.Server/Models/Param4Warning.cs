using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Param4Warning
{
    public int Id { get; set; }

    public string? AetType { get; set; }

    public string? CatCode { get; set; }

    public decimal? Total { get; set; }

    public string? Currency { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
