using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetType
{
    public int Id { get; set; }

    public string CatCode { get; set; } = null!;

    public string? CatName { get; set; }

    public int? CatParent { get; set; }

    public string? CatType { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
