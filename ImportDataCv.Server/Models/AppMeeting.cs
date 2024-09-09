using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AppMeeting
{
    public int Id { get; set; }

    public string? ZoomId { get; set; }

    public string? ZoomPasswork { get; set; }

    public string? DisplayName { get; set; }

    public string? Imei { get; set; }
}
