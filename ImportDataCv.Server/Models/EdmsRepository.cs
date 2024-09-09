using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRepository
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int ReposId { get; set; }

    public string? ReposCode { get; set; }

    public string? ReposName { get; set; }

    public string? Account { get; set; }

    public string? Server { get; set; }

    public string? Token { get; set; }

    public string? Desc { get; set; }

    public string? Parent { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DelEtedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? PassWord { get; set; }

    public string? Type { get; set; }
}
