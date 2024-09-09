using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrTrainingCourse
{
    public int Id { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? Result { get; set; }

    public int EmployeeId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? ReceivedPlace { get; set; }

    public string? TraingPlace { get; set; }

    public string? CertificateName { get; set; }

    public string? EducationName { get; set; }

    public string? InfoDetails { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? Flag { get; set; }
}
