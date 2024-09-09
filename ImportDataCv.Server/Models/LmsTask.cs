using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsTask
{
    public int Id { get; set; }

    public string LmsTaskCode { get; set; } = null!;

    public string? LmsTaskName { get; set; }

    public string? ListCode { get; set; }

    public DateTime BeginTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? BackgroundColor { get; set; }

    public string? BackgroundImage { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? LockShare { get; set; }

    public string? LmsTaskType { get; set; }

    public string? LmsTaskNext { get; set; }

    public string? LmsUserList { get; set; }

    public string? LmsItemList { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
