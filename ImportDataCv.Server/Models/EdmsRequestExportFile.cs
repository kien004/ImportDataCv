using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRequestExportFile
{
    public int Id { get; set; }

    public int? ReqId { get; set; }

    public int? FileId { get; set; }
}
