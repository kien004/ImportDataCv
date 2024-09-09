using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class View1
{
    public bool? IsDeleted { get; set; }

    public string? UserId { get; set; }

    public string TransactionCode { get; set; } = null!;

    public string? Price { get; set; }

    public int Id { get; set; }

    public string? Currency { get; set; }
}
