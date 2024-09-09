﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoCusUpdatedTracking
{
    public int Id { get; set; }

    public string? PoCusCode { get; set; }

    public string? Status { get; set; }

    public string? Confirm { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public string? UpdateContent { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
