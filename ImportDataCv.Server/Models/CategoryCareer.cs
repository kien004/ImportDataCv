using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CategoryCareer
{
    public int Id { get; set; }

    public string? CareerCode { get; set; }

    public string? CareerName { get; set; }

    public string? CareerGroup { get; set; }

    public string? CareerType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? PayGradesCode { get; set; }

    public string? Note { get; set; }
}
