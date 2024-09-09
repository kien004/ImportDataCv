using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class WarehouseLog
{
    public int Id { get; set; }

    public string? Controller { get; set; }

    public string? Action { get; set; }

    public string? Path { get; set; }

    public string? RequestHeader { get; set; }

    public string? RequestBody { get; set; }

    public string? Table { get; set; }

    public string? Ip { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }
}
