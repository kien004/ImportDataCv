using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpTransportAttrext
{
    public int Id { get; set; }

    public string? AttrCode { get; set; }

    public decimal? Value { get; set; }

    public string? TransportCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
