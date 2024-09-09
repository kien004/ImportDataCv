using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsBoxFile
{
    public int Id { get; set; }

    public int? BoxId { get; set; }

    public int? FileId { get; set; }
}
