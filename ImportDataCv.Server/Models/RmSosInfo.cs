using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmSosInfo
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Title { get; set; }

    public string? Data { get; set; }

    public int? Priority { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Address { get; set; }

    public string? ImageCode { get; set; }
}
