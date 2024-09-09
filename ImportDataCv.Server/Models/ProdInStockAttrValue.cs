using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProdInStockAttrValue
{
    public int Id { get; set; }

    public string? TicketImpCode { get; set; }

    public string? ProdCode { get; set; }

    public string? Code { get; set; }

    public string? Value { get; set; }

    public string? MarkType { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? Unit { get; set; }
}
