using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Family
{
    public int Id { get; set; }

    /// <summary>
    /// Thái độ chính trị
    /// </summary>
    public string? PoliticalAttitude { get; set; }

    /// <summary>
    /// Tôn giáo
    /// </summary>
    public string? Relation { get; set; }

    /// <summary>
    /// thành phần lớp cơ sở
    /// </summary>
    public string? ClassComposition { get; set; }

    /// <summary>
    /// Đảng viên?
    /// </summary>
    public bool? PartyMember { get; set; }

    /// <summary>
    /// năm sinh
    /// </summary>
    public string? BirthYear { get; set; }

    /// <summary>
    /// năm mất
    /// </summary>
    public string? DeathYear { get; set; }

    /// <summary>
    /// lí do mất
    /// </summary>
    public string? DeathReason { get; set; }

    /// <summary>
    /// quê quán
    /// </summary>
    public string? HomeTown { get; set; }

    /// <summary>
    /// Nơi cư trú
    /// </summary>
    public string? Residence { get; set; }

    /// <summary>
    /// Nghề nghiệp
    /// </summary>
    public string? Job { get; set; }

    /// <summary>
    /// Quá trình công tác
    /// </summary>
    public string? WorkingProgress { get; set; }

    public string? Name { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
