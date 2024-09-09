using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DbVAmchartSocialSessionLog
{
    public Guid? Id { get; set; }

    public int? LstDay { get; set; }

    public string? BotSessionResult { get; set; }
}
