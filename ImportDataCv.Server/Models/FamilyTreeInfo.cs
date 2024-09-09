using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FamilyTreeInfo
{
    public int Id { get; set; }

    public string FamilyTreeCode { get; set; } = null!;

    public string? FamilyTreeNodeCode { get; set; }

    public string? Description { get; set; }

    public string? FamilyV { get; set; }

    public string? Member { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsPublic { get; set; }
}
