using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcProductCat
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? Unit { get; set; }

    public string? PathImg { get; set; }

    public string? Note { get; set; }

    public string? ProductGroup { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? PathFile { get; set; }

    public string? FileName { get; set; }
}
