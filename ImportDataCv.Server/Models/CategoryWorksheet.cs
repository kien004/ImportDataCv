using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CategoryWorksheet
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int WorksheetId { get; set; }

    public bool? Status { get; set; }

    public int? Order { get; set; }
}
