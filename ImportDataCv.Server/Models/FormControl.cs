using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FormControl
{
    public int Id { get; set; }

    public string? FcCode { get; set; }

    public string? FcName { get; set; }

    public string? FcParent { get; set; }

    public string? FcAttribute { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
