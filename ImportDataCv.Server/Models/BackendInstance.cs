using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BackendInstance
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? HostingServer { get; set; }

    public string? Domain { get; set; }

    public string? DatabaseInstance { get; set; }

    public string? SubDomain { get; set; }

    public string? Port { get; set; }

    public string? DeployDirectory { get; set; }

    public string? SourceCode { get; set; }

    public string? SourceVersion { get; set; }

    public string? Request { get; set; }

    public string? JsonPath { get; set; }

    public string? SiteName { get; set; }

    public string? SourceInfo { get; set; }

    public string? FtpInfo { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
