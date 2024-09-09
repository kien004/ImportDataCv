using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocExtrafield
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Description { get; set; }

    public string? FieldCode { get; set; }

    public string? FieldType { get; set; }

    public string? FieldValue { get; set; }

    public int Flag { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? CompanyCode { get; set; }
}
