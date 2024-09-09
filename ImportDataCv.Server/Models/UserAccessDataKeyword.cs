using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class UserAccessDataKeyword
{
    public int Id { get; set; }

    public string? User { get; set; }

    public string? Group { get; set; }

    public string? KeyWordList { get; set; }
}
