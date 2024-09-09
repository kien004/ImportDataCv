using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsWarehouseUser
{
    public int Id { get; set; }

    public string? WhsCode { get; set; }

    public string? UserId { get; set; }

    public string? Role { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Note { get; set; }

    public string? UserName { get; set; }
}
