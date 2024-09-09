using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdAuthoring
{
    public int Id { get; set; }

    public string? FromUser { get; set; }

    public string? ToUser { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Confirm { get; set; }
}
