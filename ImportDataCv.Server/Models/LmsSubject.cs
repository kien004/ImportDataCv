using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsSubject
{
    public int Id { get; set; }

    public string? LmsSubjectCode { get; set; }

    public string? LmsSubjectName { get; set; }

    public string? LmsSubjectDesc { get; set; }

    public string? LmsSubjectGroup { get; set; }

    public string? LmsSubjectType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
