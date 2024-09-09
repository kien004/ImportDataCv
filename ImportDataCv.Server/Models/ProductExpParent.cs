using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductExpParent
{
    public int Id { get; set; }

    public int? IdExpProduct { get; set; }

    public int? IdProductParent { get; set; }

    public int? Number { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletionToken { get; set; }

    public int? IdImpProduct { get; set; }

    public virtual ProductExportDetail? IdExpProductNavigation { get; set; }
}
