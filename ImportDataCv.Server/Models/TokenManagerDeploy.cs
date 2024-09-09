using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class TokenManagerDeploy
{
    public int Id { get; set; }

    public string? ServiceType { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? Email { get; set; }

    public string? Type { get; set; }

    public string? AccountNumber { get; set; }

    public string? Key { get; set; }

    public string? ApiSecret { get; set; }

    public string? Token { get; set; }

    public string? SdkKey { get; set; }

    public string? SdkSecret { get; set; }

    public string? CredentialsJson { get; set; }

    public string? RefreshToken { get; set; }

    public string? AccountRole { get; set; }

    public int? Limit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? HostClaimCode { get; set; }

    public string? ReqCode { get; set; }
}
