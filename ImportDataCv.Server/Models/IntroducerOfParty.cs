using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class IntroducerOfParty
{
    public int Id { get; set; }

    /// <summary>
    /// Người giới thiệu
    /// </summary>
    public string? PersonIntroduced { get; set; }

    /// <summary>
    /// Ngày và nơi vào đoàn
    /// </summary>
    public string? PlaceTimeJoinUnion { get; set; }

    /// <summary>
    /// Ngày và nơi và Đảng lần thứ nhất
    /// </summary>
    public string? PlaceTimeJoinParty { get; set; }

    /// <summary>
    /// Ngày và nơi công nhận chính thức lần thứ nhất
    /// </summary>
    public string? PlaceTimeRecognize { get; set; }

    public string? ProfileCode { get; set; }

    public bool? IsDeleted { get; set; }
}
