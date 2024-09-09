using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FcmToken
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? Token { get; set; }

    public string? Device { get; set; }

    public string? AppCode { get; set; }
}
