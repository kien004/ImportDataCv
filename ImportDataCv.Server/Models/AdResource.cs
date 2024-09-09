using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdResource
{
    public string ResourceCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Api { get; set; }

    public string? Path { get; set; }

    public int? Ord { get; set; }

    public bool Status { get; set; }

    public string? ParentCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Style { get; set; }

    public bool Scope { get; set; }

    public int ResourceId { get; set; }
}
