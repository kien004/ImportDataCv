using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdLanguage
{
    public int LanguageId { get; set; }

    public string? Culture { get; set; }

    public string? DisplayName { get; set; }

    public string? Name { get; set; }

    public string? Icon { get; set; }

    public int Ordering { get; set; }

    public bool IsEnabled { get; set; }

    public bool? IsDefault { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool IsDeleted { get; set; }
}
