using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ContractFile
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ContractFileId { get; set; }

    public string? ContractCode { get; set; }

    public string? FileCode { get; set; }
}
