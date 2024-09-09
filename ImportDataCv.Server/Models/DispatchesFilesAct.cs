using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DispatchesFilesAct
{
    public int Id { get; set; }

    public string? ProcessCode { get; set; }

    public string? FileName { get; set; }

    public string? UserId { get; set; }

    public string? Soure { get; set; }

    public string? Fomart { get; set; }

    public DateTime? CreatedTime { get; set; }
}
