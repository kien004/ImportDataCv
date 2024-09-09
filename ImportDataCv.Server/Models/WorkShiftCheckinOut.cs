using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkShiftCheckinOut
{
    public int Id { get; set; }

    public string? Action { get; set; }

    public DateTime ActionTime { get; set; }

    public DateTime? ActionTo { get; set; }

    public string? Title { get; set; }

    public string? Note { get; set; }

    public string? LocationGps { get; set; }

    public string? LocationText { get; set; }

    public string? Device { get; set; }

    public string? UserId { get; set; }

    public string? Picture { get; set; }

    public string? Ip { get; set; }

    public int Session { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? ShiftCode { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? Approve { get; set; }

    public string? NotWorkType { get; set; }

    public bool? WorkHoliday { get; set; }

    public bool? IsException { get; set; }

    public string? Approver { get; set; }

    public DateTime? ApproveTime { get; set; }

    public string? Status { get; set; }

    public string? StatusLog { get; set; }

    public string? WorkflowCode { get; set; }
}
