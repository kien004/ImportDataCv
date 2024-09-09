using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ZoomManage
{
    public int Id { get; set; }

    public string? ZoomId { get; set; }

    public string? ZoomName { get; set; }

    public string? ZoomPassword { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? AccountZoom { get; set; }

    public string? Group { get; set; }

    public string? ListUserAccess { get; set; }

    public string? ListUserJoin { get; set; }

    public string? Chanel { get; set; }

    public string? JoinUrl { get; set; }

    public int? MeetingScheduleId { get; set; }

    public string? HostClaimCode { get; set; }
}
