using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CommAttribute
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int CommId { get; set; }

    public string? CommCode { get; set; }

    public string? CommValue { get; set; }

    public string? CommGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
