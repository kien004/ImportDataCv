using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class UserTrackingGp
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public DateTime? TrackingDate { get; set; }

    public string? DataGps { get; set; }
}
