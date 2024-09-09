using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmJnanaNewsCat
{
    public int Id { get; set; }

    public string? CatCode { get; set; }

    public string? CatTitle { get; set; }

    public string? CatDescription { get; set; }

    public int? CatParentCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int CatStatus { get; set; }

    public string? CatAvarta { get; set; }

    public string? CompanyCode { get; set; }
}
