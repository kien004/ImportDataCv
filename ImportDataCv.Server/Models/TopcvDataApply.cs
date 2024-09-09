using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class TopcvDataApply
{
    public int Id { get; set; }

    public string? CandidateName { get; set; }

    public string? TypeCv { get; set; }

    public string? Infomation { get; set; }

    public string? Insights { get; set; }

    public bool? IsDownload { get; set; }

    public string? ServeFile { get; set; }

    public string? TopcvUrl { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? ApplyId { get; set; }
}
