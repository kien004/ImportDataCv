using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectCusSup
{
    public int Id { get; set; }

    public string? ObjCode { get; set; }

    public string? ObjType { get; set; }

    public string? Role { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? ProjectCode { get; set; }

    public bool IsMain { get; set; }
}
