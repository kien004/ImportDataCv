using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsWhsQrcodeDocument
{
    public int Id { get; set; }

    public string? ObjCode { get; set; }

    public string? ObjType { get; set; }

    public string? QrCode { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool Flag { get; set; }

    public int? PrintNumber { get; set; }

    public int? RackPosition { get; set; }
}
