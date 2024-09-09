using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PAreaCategory
{
    public int Id { get; set; }

    public string? PAreaCode { get; set; }

    public string? PAreaParent { get; set; }

    public string? PAreaType { get; set; }

    public string? PAreaDescription { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
