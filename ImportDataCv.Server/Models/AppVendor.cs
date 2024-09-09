using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AppVendor
{
    public int Id { get; set; }

    public string VendorCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? GoogleMap { get; set; }

    public string? Email { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
