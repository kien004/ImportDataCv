using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LinkedInDataProfileId
{
    public int Id { get; set; }

    public string? LinkedInUrl { get; set; }

    public string? LinkedInProfileId { get; set; }

    public DateTime? CreatedTime { get; set; }
}
