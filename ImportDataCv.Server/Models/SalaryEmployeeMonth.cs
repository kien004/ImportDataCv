using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SalaryEmployeeMonth
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? SalaryRatio { get; set; }

    public string? SalaryLevel { get; set; }

    public DateOnly Month { get; set; }

    public decimal? D { get; set; }

    public decimal? E { get; set; }

    public decimal? F { get; set; }

    public decimal? G { get; set; }

    public decimal? H { get; set; }

    public decimal? I { get; set; }

    public decimal? J { get; set; }

    public decimal? K { get; set; }

    public decimal? L { get; set; }

    public decimal? M { get; set; }

    public decimal? N { get; set; }

    public decimal? O { get; set; }

    public decimal? P { get; set; }

    public decimal? Q { get; set; }

    public decimal? R { get; set; }

    public decimal? S { get; set; }

    public decimal? At { get; set; }

    public decimal? T { get; set; }

    public decimal? U { get; set; }

    public decimal? V { get; set; }

    public decimal? Vr { get; set; }

    public decimal? X { get; set; }

    public decimal? Y { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    public decimal? TotalDay { get; set; }
}
