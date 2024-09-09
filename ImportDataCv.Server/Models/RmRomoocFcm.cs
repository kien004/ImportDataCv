using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocFcm
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public int UserId { get; set; }
}
