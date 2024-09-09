﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PayScaleDetail
{
    public int Id { get; set; }

    public string? ScaleCode { get; set; }

    public string? Ranges { get; set; }

    public decimal? Coeff { get; set; }

    public string? ScaleDtCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public decimal? Salary { get; set; }

    public string? CareerCode { get; set; }
}
