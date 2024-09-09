using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmJnanaCountRequestGoogle
{
    public int Id { get; set; }

    public DateTime CreateTime { get; set; }

    public string? Date { get; set; }

    public int IsLimit { get; set; }

    public string? Key { get; set; }

    public int NumRequest { get; set; }

    public string? ServiceType { get; set; }

    public DateTime UpdateTime { get; set; }

    public string? Device { get; set; }
}
