using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsTimeOfDocumentPreservationCommon
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public int StorageTimeLimit { get; set; }

    public string? TypeLevel1 { get; set; }

    public string? TypeLevel2 { get; set; }

    public string? GroupLevel1 { get; set; }

    public string? GroupLevel2 { get; set; }

    public string? GroupLevel3 { get; set; }

    public string? TitleFull { get; set; }

    public bool IsDeleted { get; set; }
}
