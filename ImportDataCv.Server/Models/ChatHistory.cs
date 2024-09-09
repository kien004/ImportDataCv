using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ChatHistory
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? MessageType { get; set; }

    public string? GroupCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
