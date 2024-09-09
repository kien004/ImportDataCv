using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CommitmentDetail
{
    public int Id { get; set; }

    public string? CommitmentCode { get; set; }

    public string? ItemCode { get; set; }

    public bool? Flag { get; set; }
}
