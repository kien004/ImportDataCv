using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdLanguageText
{
    public int LanguageTextId { get; set; }

    public int LanguageId { get; set; }

    public string? Caption { get; set; }

    public string? Value { get; set; }

    public string? GroupCaption { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool IsDeleted { get; set; }
}
