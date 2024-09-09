using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DatabaseServer
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Address { get; set; }

    public string? Name { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? AddressNet { get; set; }

    public string? Type { get; set; }

    public bool? Enabled { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
