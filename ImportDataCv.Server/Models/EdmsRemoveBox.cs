using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRemoveBox
{
    public int Id { get; set; }

    public int RemoveId { get; set; }

    public int BoxId { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
