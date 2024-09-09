using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AdApplication
{
    public string ApplicationCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? AppUrl { get; set; }

    public string? Icon { get; set; }

    public int Status { get; set; }

    public int? Ord { get; set; }

    public string? AuthenticationScheme { get; set; }

    public string? Authority { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public string? NameClaimType { get; set; }

    public int? RequireHttps { get; set; }

    public string? ResponseType { get; set; }

    public string? RoleClaimType { get; set; }

    public string? Scope { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int ApplicationId { get; set; }
}
