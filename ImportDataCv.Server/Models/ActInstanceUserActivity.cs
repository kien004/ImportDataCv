using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ActInstanceUserActivity
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? ActInstCode { get; set; }

    public string? Action { get; set; }

    public bool IsCheck { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? FromDevice { get; set; }

    public string? IdObject { get; set; }

    public string? ChangeDetails { get; set; }

    public string? Log { get; set; }
}
