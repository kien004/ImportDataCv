using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class TrainingCertificatedPass
{
    public int Id { get; set; }

    public string? SchoolName { get; set; }

    public string? Class { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    /// <summary>
    /// Chứng chỉ
    /// </summary>
    public string? Certificate { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
