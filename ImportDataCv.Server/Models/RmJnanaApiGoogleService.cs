using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmJnanaApiGoogleService
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Key { get; set; }

    public int Limit { get; set; }

    public string? ServiceType { get; set; }
}
