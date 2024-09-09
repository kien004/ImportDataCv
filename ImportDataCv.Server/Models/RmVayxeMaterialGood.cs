using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeMaterialGood
{
    public int Id { get; set; }

    public string? CodeId { get; set; }

    public string? ProductName { get; set; }

    public string? GroupId { get; set; }

    public string? TypeId { get; set; }

    public string? Note { get; set; }

    public int? Accessory { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Flag { get; set; }

    public string? Barcode { get; set; }

    public string? Image { get; set; }
}
