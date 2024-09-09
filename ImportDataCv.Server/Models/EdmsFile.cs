using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsFile
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int FileId { get; set; }

    public string? FileCode { get; set; }

    public string? FileName { get; set; }

    public decimal? FileSize { get; set; }

    public string? FileTypePhysic { get; set; }

    public string? FileTypeWork { get; set; }

    public string? Desc { get; set; }

    public string? Tags { get; set; }

    public string? Url { get; set; }

    public string? ReposCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? NumberDocument { get; set; }

    public string? MimeType { get; set; }

    public string? CloudFileId { get; set; }

    public bool? IsEdit { get; set; }

    public bool? IsFileMaster { get; set; }

    public bool? IsFileOrigin { get; set; }

    public int? FileParentId { get; set; }

    public string? EditedFileBy { get; set; }

    public DateTime? EditedFileTime { get; set; }

    public string? ListUserView { get; set; }

    public bool? IsScan { get; set; }

    public string? QrCode { get; set; }

    public string? MetaDataExt { get; set; }

    public bool? IsSearchIndex { get; set; }

    public string? AudioBook { get; set; }

    public decimal? Price { get; set; }
}
