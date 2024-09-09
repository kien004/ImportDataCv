﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectProductDetail
{
    public int Id { get; set; }

    public string? TicketCode { get; set; }

    public string? ProductCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? Unit { get; set; }

    public decimal? Cost { get; set; }

    public string? SupplierCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
