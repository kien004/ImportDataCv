using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class UsrKeyWordSetup
{
    public int Id { get; set; }

    public string? KeyWord { get; set; }

    public string? Unit { get; set; }

    public string? Type { get; set; }

    public string? Group { get; set; }

    public string? UserId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
