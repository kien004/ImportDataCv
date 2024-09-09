﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpPumpFrameTicket
{
    public int Id { get; set; }

    public string? SessionCode { get; set; }

    public string? PumpFrameCode { get; set; }

    public DateTime? ProductTime { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
