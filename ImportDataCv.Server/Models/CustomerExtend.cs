using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CustomerExtend
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Extend Id
    /// </summary>
    public string? ExtCode { get; set; }

    /// <summary>
    /// Customer Id
    /// </summary>
    public int? CustomerId { get; set; }

    /// <summary>
    /// Create Time
    /// </summary>
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// Update Time
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// Flag
    /// </summary>
    public bool? Flag { get; set; }

    public string? ExtValue { get; set; }

    public string? ExtGroup { get; set; }

    public bool Isdeleted { get; set; }
}
