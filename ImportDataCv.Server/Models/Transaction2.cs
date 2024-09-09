using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Transaction2
{
    public int Id { get; set; }

    public string TransactionCode { get; set; } = null!;

    public string? UserId { get; set; }

    public string? Price { get; set; }

    public string? Currency { get; set; }

    public string? TransactionDate { get; set; }

    public string? Note { get; set; }

    public string? Location { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
