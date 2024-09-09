using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CameraRoom
{
    public string? DepartmentCode { get; set; }

    public string? RoomId { get; set; }

    public string? RoomName { get; set; }

    public int? CameraQuantity { get; set; }

    public int? CameraAvailable { get; set; }

    public string? Series { get; set; }

    public string? Capacity { get; set; }

    public string? DiskStatus { get; set; }

    public string? SignalLossReason { get; set; }

    public string? Note { get; set; }

    public bool? DiskSaveable { get; set; }

    public string? LoginInformation { get; set; }

    public string? ImageLink { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public int Id { get; set; }
}
