using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdUserDepartment
{
    public int Id { get; set; }

    public string? DepartmentCode { get; set; }

    public string? UserId { get; set; }

    public string? RoleId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? Branch { get; set; }

    public bool? IsMain { get; set; }
}
