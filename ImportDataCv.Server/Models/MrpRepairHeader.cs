using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpRepairHeader
{
    public int Id { get; set; }

    public string? ReqCode { get; set; }

    public string? Title { get; set; }

    public string? Status { get; set; }

    public DateTime? RepairDate { get; set; }

    public string? Repairer { get; set; }

    public string? ImpCode { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
