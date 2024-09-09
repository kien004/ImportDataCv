using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsRepoDefaultObject
{
    public int Id { get; set; }

    public string? ReposCode { get; set; }

    public string? CatCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectType { get; set; }

    public string? Path { get; set; }

    public string? FolderId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public int? CatRepoSettingId { get; set; }
}
