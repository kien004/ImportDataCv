using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CardProduct
{
    public int Id { get; set; }

    public string? CardCode { get; set; }

    public string? ProductCode { get; set; }

    public int Quantity { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }
}
