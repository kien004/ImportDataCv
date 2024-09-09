using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HostingServer
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Ip { get; set; }

    public string? Name { get; set; }

    public bool? IsReserveProxy { get; set; }

    public string? CtwDirectory { get; set; }

    public string? Port { get; set; }

    public string? DeployAddress { get; set; }

    public string? DeployDirectory { get; set; }

    public string? GitDirectory { get; set; }

    public string? ReserveProxyInfo { get; set; }

    public string? FtpServerInfo { get; set; }

    public bool? Enabled { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
