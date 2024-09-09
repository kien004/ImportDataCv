using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Transition
{
    public int Id { get; set; }

    public string? TrsCode { get; set; }

    public string? TrsTitle { get; set; }

    public string? TrsType { get; set; }

    public string? TrsNoted { get; set; }

    public string? TrsAttrGraph { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? TrsParent { get; set; }
}
