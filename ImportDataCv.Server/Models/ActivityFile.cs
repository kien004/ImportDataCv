﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ActivityFile
{
    public int Id { get; set; }

    public string? ActivityCode { get; set; }

    public string? FileId { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? FileType { get; set; }

    public decimal? FileSize { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
