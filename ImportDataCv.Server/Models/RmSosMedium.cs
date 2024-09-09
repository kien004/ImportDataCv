using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmSosMedium
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public string? Extension { get; set; }

    public double? Size { get; set; }

    public string? SosCode { get; set; }

    public string? Code { get; set; }

    public byte[]? ImageBinary { get; set; }
}
