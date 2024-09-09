using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WorkExecutiveObjectrelative
{
    public int Id { get; set; }

    public string? ListCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectModule { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool Flag { get; set; }
}
