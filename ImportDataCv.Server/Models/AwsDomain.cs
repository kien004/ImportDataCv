using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AwsDomain
{
    public int Id { get; set; }

    public string? SystemName { get; set; }

    public string? HostedZoneId { get; set; }

    public string? Domain { get; set; }

    public bool? Enabled { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
