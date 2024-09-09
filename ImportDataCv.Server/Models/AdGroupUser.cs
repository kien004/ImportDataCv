using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdGroupUser
{
    public string GroupUserCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? ParentCode { get; set; }

    public string? Description { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsEnabled { get; set; }

    public int GroupUserId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public int? Priority { get; set; }

    public virtual ICollection<MobilePermission> MobilePermissions { get; set; } = new List<MobilePermission>();
}
