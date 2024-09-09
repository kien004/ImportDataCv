using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MaterialFile
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Fomart { get; set; }

    public string? ProductCode { get; set; }

    public string? Soure { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
