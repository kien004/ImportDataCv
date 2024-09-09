using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeCatSevice
{
    public int Id { get; set; }

    public string? ServiceCode { get; set; }

    public string? ServiceName { get; set; }

    public string? ServiceGroupId { get; set; }

    public string? ServiceTypeId { get; set; }

    public string? Note { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }

    public string? IllustratorImg { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
