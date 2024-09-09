using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AncestralHouse
{
    public int Id { get; set; }

    public string AncestCode { get; set; } = null!;

    public string? Title { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? Ward { get; set; }

    public string? AddressTxt { get; set; }

    public string? AddressGps { get; set; }

    public string? DataGps { get; set; }

    public string? Description { get; set; }

    public string? Media { get; set; }

    public string? Avartar { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool? IsEnable { get; set; }

    public string? FamilyTreeCode { get; set; }

    public bool? IsDeleted { get; set; }
}
