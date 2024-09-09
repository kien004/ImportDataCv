using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MobileFunction
{
    public string FunctionCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Ord { get; set; }

    public string? ParentCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int FunctionId { get; set; }

    public virtual ICollection<MobileFunction> InverseParentCodeNavigation { get; set; } = new List<MobileFunction>();

    public virtual ICollection<MobilePermission> MobilePermissions { get; set; } = new List<MobilePermission>();

    public virtual MobileFunction? ParentCodeNavigation { get; set; }
}
