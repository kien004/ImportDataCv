﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VSubjectHierachy
{
    public int? Id { get; set; }

    public string? SubjectCode { get; set; }

    public string? SubjectName { get; set; }

    public string? SubjectDescription { get; set; }

    public int? Duration { get; set; }

    public string? Unit { get; set; }

    public string? ImageCover { get; set; }

    public string? VideoPresent { get; set; }

    public string? FileBase { get; set; }

    public string? Status { get; set; }

    public string? Teacher { get; set; }

    public string? Author { get; set; }

    public int? Parent { get; set; }

    public string? EdmsCatCode { get; set; }

    public string? IconFa { get; set; }

    public bool? IsTutor888 { get; set; }

    public int? Id888 { get; set; }

    public int? HierachyLevel { get; set; }

    public string? HierachyDesc { get; set; }

    public string? HierachyCode { get; set; }
}
