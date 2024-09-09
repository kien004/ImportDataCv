using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CandidateBasic
{
    public int Id { get; set; }

    public string? CandidateCode { get; set; }

    public string? Fullname { get; set; }

    public int Sex { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool Married { get; set; }

    public string? Skype { get; set; }

    public string? FileCv1 { get; set; }

    public string? FileCv2 { get; set; }

    public string? FileCv3 { get; set; }

    public string? MainSkill { get; set; }

    public string? MainPracticeTime { get; set; }

    public string? SubSkill { get; set; }

    public string? SubPracticeTime { get; set; }

    public string? LanguageUse { get; set; }

    public string? Ability { get; set; }

    public decimal? SalaryHope { get; set; }

    public string? Currency { get; set; }

    public string? LaptopInfo { get; set; }

    public string? SmartphoneInfo { get; set; }

    public DateTime? DateQuit { get; set; }

    public string? Targeting { get; set; }

    public DateTime? CanJoinDate { get; set; }

    public string? WorkPlace { get; set; }

    public DateTime? WorkFrom { get; set; }

    public DateTime? WorkTo { get; set; }

    public int? WorkType { get; set; }

    public DateTime? AppointmentTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? Status { get; set; }

    public string? LogStatus { get; set; }
}
