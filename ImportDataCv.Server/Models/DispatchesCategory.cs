using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DispatchesCategory
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DocumentType { get; set; }

    public int? NumberCreator { get; set; }

    public string? DocumentSymbol { get; set; }

    public int? ExpriedProcess { get; set; }

    public bool? IsYearBefore { get; set; }

    public int? Year { get; set; }

    public string? TypeM { get; set; }
}
