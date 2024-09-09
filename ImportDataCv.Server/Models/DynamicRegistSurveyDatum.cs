using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DynamicRegistSurveyDatum
{
    public int Id { get; set; }

    public string? SurveyCode { get; set; }

    public string? AttrValue { get; set; }

    public string? UserName { get; set; }
}
