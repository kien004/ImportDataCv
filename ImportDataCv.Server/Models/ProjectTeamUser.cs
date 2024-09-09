using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectTeamUser
{
    public int Id { get; set; }

    public string? TeamCode { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Table { get; set; }

    public bool? IsDeleted { get; set; }
}
