using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LogMessage
{
    public int Id { get; set; }

    public string? Channel { get; set; }

    public string? Content { get; set; }

    public string? User { get; set; }

    public DateTime? TimeChat { get; set; }

    public string? Image { get; set; }

    public string? GivenName { get; set; }

    public string? GroupCode { get; set; }

    public bool? IsFile { get; set; }

    public int? FileId { get; set; }

    public string? Url { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }
}
