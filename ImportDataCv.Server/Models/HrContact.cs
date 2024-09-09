using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrContact
{
    public int Id { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Note { get; set; }

    public int EmployeeId { get; set; }

    public string? Relationship { get; set; }

    public string? Name { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? JobName { get; set; }

    public DateTime? Birthday { get; set; }

    public int? Flag { get; set; }
}
