using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrEmployeeDecision
{
    public int Id { get; set; }

    public string? DecisionCode { get; set; }

    public DateTime? DecisionDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 1- Chấm dứt hợp đồng
    /// 2- Điều động nhân sự
    /// 3- Chuyển phong ban nhân sự
    /// </summary>
    public int? Style { get; set; }

    public DateTime? DecisionMakingDate { get; set; }
}
