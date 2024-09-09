using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsFloorAsset
{
    public int Id { get; set; }

    public string? FloorCode { get; set; }

    public string? QrCode { get; set; }

    public string? AreaSquare { get; set; }

    public string? MapDesgin { get; set; }

    public string? Note { get; set; }

    public string? Image { get; set; }

    public int? CntLine { get; set; }

    public string? Status { get; set; }

    public string? WhsCode { get; set; }

    public string? ManagerId { get; set; }

    public string? FloorName { get; set; }

    public string? Temperature { get; set; }

    public string? Humidity { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
