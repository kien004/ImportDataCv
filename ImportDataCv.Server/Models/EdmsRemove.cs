using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRemove
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Business { get; set; }

    public string? PersonProcessor { get; set; }

    public string? Note { get; set; }

    public string? Picture { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
