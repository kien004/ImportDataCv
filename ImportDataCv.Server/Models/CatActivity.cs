﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CatActivity
{
    public string? ActCode { get; set; }

    public string? ActName { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public int Id { get; set; }

    public string? ActType { get; set; }

    public string? ActGroup { get; set; }

    public string? FileUrl { get; set; }

    public int? IdMapping { get; set; }

    public string? FileName { get; set; }
}
