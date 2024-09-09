using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeTableCostDetail
{
    public int Id { get; set; }

    public string? ServiceCode { get; set; }

    public int? TableId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
