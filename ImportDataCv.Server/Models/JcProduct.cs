using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class JcProduct
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public int? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? JcAct { get; set; }

    public string? CardCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
