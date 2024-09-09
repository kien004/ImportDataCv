using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VActionCard
{
    public Guid? Id { get; set; }

    public string CardCode { get; set; } = null!;

    public string? CardName { get; set; }

    public string? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
