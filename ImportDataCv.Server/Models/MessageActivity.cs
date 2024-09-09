using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MessageActivity
{
    public int Id { get; set; }

    public string? User { get; set; }

    public string? ActFrom { get; set; }

    public string? ActTo { get; set; }

    public string? Command { get; set; }

    public DateTime? CommandTime { get; set; }

    public string? Confirm { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public string? Note { get; set; }

    public string? ConfirmedBy { get; set; }
}
