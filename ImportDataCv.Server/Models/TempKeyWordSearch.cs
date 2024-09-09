using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class TempKeyWordSearch
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Value { get; set; }

    public string? Unit { get; set; }

    public string? DataType { get; set; }

    public string? DocumentId { get; set; }

    public string? Group { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? KeySearch { get; set; }
}
