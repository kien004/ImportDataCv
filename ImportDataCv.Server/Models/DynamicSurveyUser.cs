using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DynamicSurveyUser
{
    public int Id { get; set; }

    public string? AttrGroup { get; set; }

    public string? TimeEat { get; set; }

    public string? Price { get; set; }

    public string? CreatedBy { get; set; }

    public string? Note { get; set; }
}
