using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeBookMaterialDetail
{
    public int Id { get; set; }

    public int? BookChkId { get; set; }

    public int? MaterialId { get; set; }

    public int? Amount { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }

    public double? Price { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
