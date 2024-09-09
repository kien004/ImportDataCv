using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ObjectTypeStatusGroup
{
    public int Id { get; set; }

    public string? ObjectTypeCode { get; set; }

    public string? StatusGroupCode { get; set; }
}
