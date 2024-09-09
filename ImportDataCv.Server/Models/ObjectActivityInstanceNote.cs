using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ObjectActivityInstanceNote
{
    public int Id { get; set; }

    public string? ActivityInstCode { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectJsonConstraintView { get; set; }

    public string? ObjectJsonData { get; set; }

    public string? ObjectJsonDataUser { get; set; }

    public string? ListUser { get; set; }

    public string? ActivityInstShare { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
