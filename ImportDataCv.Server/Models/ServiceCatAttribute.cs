using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ServiceCatAttribute
{
    public int Id { get; set; }

    public string? AttributeCode { get; set; }

    public string? AttributeName { get; set; }

    public string? AttributeValue { get; set; }

    public string? FieldType { get; set; }

    public string? Note { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
