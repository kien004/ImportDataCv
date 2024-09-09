using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeVendor
{
    public int Id { get; set; }

    public string? VendorCode { get; set; }

    public string? VendorContact { get; set; }

    public string? VendorName { get; set; }

    public string? VendorLogo { get; set; }

    public string? VendorPhone { get; set; }

    public int? VendorType { get; set; }

    public string? VendorWebsite { get; set; }

    public string? VendorFb { get; set; }

    public string? VendorDesc { get; set; }

    public int? Flag { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? CreateBy { get; set; }

    public int? UpdateBy { get; set; }

    public string? VendorAddress { get; set; }

    public bool? IsDelete { get; set; }

    public string? GeoCode { get; set; }
}
