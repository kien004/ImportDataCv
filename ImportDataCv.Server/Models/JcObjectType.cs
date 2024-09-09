using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class JcObjectType
{
    public int Id { get; set; }

    public string? ObjTypeCode { get; set; }

    public string? ObjTypeName { get; set; }

    public string? ScriptSql { get; set; }

    public string? ScriptLinq { get; set; }

    public string? Note { get; set; }

    public string? TableName { get; set; }

    public string? ClassLinq { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
