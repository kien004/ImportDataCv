using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrudHung
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? UserSelectId { get; set; }

    public string? Location { get; set; }

    public DateTime? Time { get; set; }
}
