using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcAppAccessLog
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Token { get; set; }

    public string? Status { get; set; }

    public string? Imei { get; set; }
}
