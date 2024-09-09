using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class OperationOnlineSupport
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? PassWord { get; set; }

    public string? TitleName { get; set; }

    public string? UserType { get; set; }

    public DateTime? LastCallTime { get; set; }

    public string? LocationCall { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
