using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Team
{
    public int Id { get; set; }

    public string TeamCode { get; set; } = null!;

    public string? TeamName { get; set; }

    public string? Members { get; set; }

    public string? Status { get; set; }

    public string? Leader { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? Description { get; set; }
}
