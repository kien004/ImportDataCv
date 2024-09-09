using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerRunningLog
{
    public int Id { get; set; }

    public string? SessionCode { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? UrlScanJson { get; set; }

    public string? FileDownloadJson { get; set; }

    public int? NumOfFile { get; set; }

    public string? FileResultData { get; set; }

    public int? NumPasscap { get; set; }

    public string? UserIdRunning { get; set; }

    public string? Ip { get; set; }

    public string? Status { get; set; }

    public string? BotCode { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public int? TimeScan { get; set; }

    public string? KeyWord { get; set; }

    public int? FileSizeDownload { get; set; }
}
