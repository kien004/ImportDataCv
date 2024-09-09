using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ZoneSetup
{
    public int Id { get; set; }

    public string? ZoneCode { get; set; }

    public string? ZoneName { get; set; }

    public string? ZoneAddressTxt { get; set; }

    public string? ZoneAddressGps { get; set; }

    public string? ZoneImage { get; set; }

    public string? ZoneDesc { get; set; }

    public string? ZoneStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
