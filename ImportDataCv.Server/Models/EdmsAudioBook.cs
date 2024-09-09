using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsAudioBook
{
    public int Id { get; set; }

    public int? FileId { get; set; }

    public int? Index { get; set; }

    public string? AudioPath { get; set; }
}
