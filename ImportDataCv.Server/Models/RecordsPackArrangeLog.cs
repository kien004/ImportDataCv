using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RecordsPackArrangeLog
{
    public int Id { get; set; }

    public string? Action { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectCode { get; set; }

    public string? Message { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }
}
