using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DynamicRegistSurvey
{
    public int Id { get; set; }

    public string? SurveyCode { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? Title { get; set; }

    public string? Repeat { get; set; }

    public string? Description { get; set; }

    public string? Prioritized { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public bool? Flag { get; set; }

    public string? ImageCover { get; set; }
}
