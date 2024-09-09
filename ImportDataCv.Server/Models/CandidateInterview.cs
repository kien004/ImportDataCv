using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CandidateInterview
{
    public int Id { get; set; }

    public string CandidateCode { get; set; } = null!;

    /// <summary>
    /// Ngày tới phỏng vấn
    /// </summary>
    public DateTime InterviewDate { get; set; }

    /// <summary>
    /// Trạng thái
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Có mặt
    /// </summary>
    public bool? IsPresent { get; set; }
}
