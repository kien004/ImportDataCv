using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsUserClass
{
    public int Id { get; set; }

    public string? ClassCode { get; set; }

    public string? UserName { get; set; }
}
