using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkingTracking
{
    public int Id { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string? Work { get; set; }

    /// <summary>
    /// Vai trò, vị trí
    /// </summary>
    public string? Role { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
