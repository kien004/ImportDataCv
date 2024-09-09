using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FamilyNodeInfo
{
    public int Id { get; set; }

    public string NodeCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string? AliasName { get; set; }

    public string? Sex { get; set; }

    public string? FamilyName { get; set; }

    public string? FamilyNameGroup { get; set; }

    public string? Hashtag { get; set; }

    public string? Period { get; set; }

    public string? Parent { get; set; }

    public int Level { get; set; }

    public string? CityProvince { get; set; }

    public string? Dicstrict { get; set; }

    public string? Wards { get; set; }

    public string? AddressFull { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? BirthdayPlaceGps { get; set; }

    public string? BirthdayText { get; set; }

    public DateOnly? DeadDay { get; set; }

    public string? DeadPlaceGps { get; set; }

    public string? Image { get; set; }

    public string? SocialLink { get; set; }

    public string? MarriedHist { get; set; }

    public string? Description { get; set; }

    public string? Siblings { get; set; }

    public string? MotherId { get; set; }

    public string? MultipleMediaList { get; set; }

    public string? Avartar { get; set; }

    public int? Hand { get; set; }

    public int? Branch { get; set; }

    public string? Role { get; set; }

    public string? No { get; set; }

    public bool? IsDeleted { get; set; }

    public double? LocationX { get; set; }

    public double? LocationY { get; set; }

    public string? FamilyTreeNodeCode { get; set; }

    public string? LineColor { get; set; }

    public string? LineStyle { get; set; }
}
