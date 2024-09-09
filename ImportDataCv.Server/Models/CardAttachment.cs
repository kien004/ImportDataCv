using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CardAttachment
{
    public int Id { get; set; }

    public string? CardCode { get; set; }

    public string? FileCode { get; set; }

    public string? MemberId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? FileName { get; set; }

    public string? FileUrl { get; set; }

    /// <summary>
    /// Type=0(Tệp tin), Type=1(Hình ảnh)
    /// </summary>
    public int? FileType { get; set; }

    public bool? Flag { get; set; }

    public bool? IsEdit { get; set; }

    public string? ListUserView { get; set; }

    public string? ListPermissionViewFile { get; set; }

    public string? ChkListCode { get; set; }

    public bool? IsEdms { get; set; }

    public int? IdMapping { get; set; }
}
