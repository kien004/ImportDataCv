using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsReceiptInputFile
{
    public int Id { get; set; }

    public int? RecId { get; set; }

    public int? FileId { get; set; }
}
