using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsLineDocument
{
    public int Id { get; set; }

    public string? LineCode { get; set; }

    public string? LPosition { get; set; }

    public string? LSize { get; set; }

    public string? LText { get; set; }

    public int? CntRack { get; set; }

    public string? Note { get; set; }

    public string? FloorCode { get; set; }

    public string? LColor { get; set; }

    public string? LStatus { get; set; }

    public string? QrCode { get; set; }

    public string? ShapeData { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
