using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MaterialAttribute
{
    public int Id { get; set; }

    public string? Attribute { get; set; }

    public string? AttributeValue { get; set; }

    public string? Note { get; set; }

    public int? ProductId { get; set; }
}
