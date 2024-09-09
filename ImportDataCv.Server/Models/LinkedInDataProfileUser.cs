using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LinkedInDataProfileUser
{
    public int Id { get; set; }

    public string? ProfileUrl { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? ElementSite { get; set; }
}
