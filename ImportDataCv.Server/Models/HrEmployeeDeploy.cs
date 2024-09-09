using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrEmployeeDeploy
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string? Nickname { get; set; }

    public int? Gender { get; set; }

    public string? Nation { get; set; }

    public string? Religion { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Birthofplace { get; set; }

    public string? Permanentresidence { get; set; }

    public string? Phone { get; set; }

    public DateTime? Factiondate { get; set; }

    public string? Educationallevel { get; set; }

    public string? Languagelevel { get; set; }

    public string? Health { get; set; }

    public string? Identitycard { get; set; }

    public DateTime? Identitycarddate { get; set; }

    public string? Identitycardplace { get; set; }

    public string? Socialinsurance { get; set; }

    public DateTime? Socialinsurancedate { get; set; }

    public string? Socialinsuranceplace { get; set; }

    public string? Identification { get; set; }

    public string? Unit { get; set; }

    public string? Wage { get; set; }

    public string? Salarytype { get; set; }

    public string? Salarygroup { get; set; }

    public double? Salaryfactor { get; set; }

    public string? Trainingschool { get; set; }

    public string? Trainingtime { get; set; }

    public string? Trainingtype { get; set; }

    public string? Disciplines { get; set; }

    public string? Specialized { get; set; }

    public string? Picture { get; set; }

    public string? Taxcode { get; set; }

    public string? Position { get; set; }

    public string? Employeekind { get; set; }

    public string? Emailuser { get; set; }

    public string? Emailpassword { get; set; }

    public string? Nationlaty { get; set; }

    public string? Status { get; set; }

    public string? Employeetype { get; set; }

    public string? Bank { get; set; }

    public string? Accountholder { get; set; }

    public string? Accountopenplace { get; set; }

    public string? Accountnumber { get; set; }

    public int? Maritalstatus { get; set; }

    public string? Computerskill { get; set; }

    public string? Employeegroup { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Updatetime { get; set; }

    public string? Language { get; set; }

    public int? Flag { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? IdDriver { get; set; }

    public string? CompanyCode { get; set; }

    public string? EmployeeCode { get; set; }

    public DateTime? WorkFrom { get; set; }

    public DateTime? WorkTo { get; set; }

    public string? WorkType { get; set; }

    public decimal? YearsOfExp { get; set; }

    public string? ShiftList { get; set; }

    public string? PayScale { get; set; }

    public string? PayRange { get; set; }

    public string? PayCoef { get; set; }

    public string? PayCareer { get; set; }

    public string? PayTitle { get; set; }

    public string? PayCertificate { get; set; }

    public string? PayMajor { get; set; }

    public string? InsuranceBookNumber { get; set; }

    public string? SalaryBookNumber { get; set; }

    public string? LogPayScale { get; set; }

    public string? LogPayRange { get; set; }

    public string? LogEndContract { get; set; }

    public string? LogMovement { get; set; }

    public string? LogStatus { get; set; }

    public string? LogDepartment { get; set; }

    public string? LogPosition { get; set; }

    public decimal? Salary { get; set; }

    public string? NotWorkDay { get; set; }

    public int? Order { get; set; }

    public string? MarkedBy { get; set; }

    public DateTime? MarkedTime { get; set; }

    public string? QrCodePayment { get; set; }

    public string? JsonStatus { get; set; }

    public string? ReqCode { get; set; }

    public string? PayTitleName { get; set; }

    public string? PayCertificateName { get; set; }

    public string? PayMajorName { get; set; }
}
