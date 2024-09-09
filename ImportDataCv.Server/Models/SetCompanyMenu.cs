using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SetCompanyMenu
{
    public int Id { get; set; }

    public string MenuCaption { get; set; } = null!;

    public string? Title { get; set; }

    public string? MenuParent { get; set; }

    public string? Note { get; set; }

    public string Action { get; set; } = null!;

    public string Pin { get; set; } = null!;

    public int Priority { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
