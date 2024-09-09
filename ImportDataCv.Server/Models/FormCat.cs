using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FormCat
{
    public int Id { get; set; }

    public string? FormCode { get; set; }

    public string? FormName { get; set; }

    public string? FormNote { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FormType { get; set; }

    public string? FormGroup { get; set; }
}
