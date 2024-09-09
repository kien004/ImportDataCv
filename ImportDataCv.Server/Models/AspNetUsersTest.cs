using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AspNetUsersTest
{
    public string Id { get; set; } = null!;

    public string? ConcurrencyStamp { get; set; }

    public string UserName { get; set; } = null!;

    public string NormalizedUserName { get; set; } = null!;

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public bool LockoutEnabled { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PasswordHash { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public string? FamilyName { get; set; }

    public string? MiddleName { get; set; }

    public string? GivenName { get; set; }

    public decimal? OfficeNumber { get; set; }

    public string? Picture { get; set; }

    public bool Active { get; set; }

    public string? EmployeeCode { get; set; }

    public string? BranchId { get; set; }

    public string? AccountExecutiveId { get; set; }

    public string? OrgReference { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public string? Reason { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UserType { get; set; }

    public bool IsExceeded { get; set; }

    public bool? Gender { get; set; }

    public bool? IsCheckin { get; set; }

    public int IsOnline { get; set; }

    public string? Area { get; set; }

    public int? TypeStaff { get; set; }

    public string? TypeWork { get; set; }

    public string? DepartmentId { get; set; }

    public string? RoleCombination { get; set; }

    public int? LoginFailCount { get; set; }

    public string? ShiftList { get; set; }

    public string? SignImage { get; set; }

    public string? SessionLogin { get; set; }
}
