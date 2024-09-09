using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class IotAnalysisAction
{
    public int Id { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Address { get; set; }

    public string? FaceId { get; set; }

    public string? NameFace { get; set; }

    public string? ObjType { get; set; }

    public decimal? Total { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Image1 { get; set; }

    public string? Image2 { get; set; }

    public string? Image3 { get; set; }

    public string? Image4 { get; set; }
}
