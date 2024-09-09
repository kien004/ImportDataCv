using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CrawlerBotManagement
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public string? BotSessionCode { get; set; }

    public string? IdentifierBot { get; set; }

    public string? ListKeyWord { get; set; }

    public string? DataStoragePath { get; set; }

    public string? ConfigSelectorJson { get; set; }

    public string? ConfigSelectorJsonSendData { get; set; }

    public string? RobotCode { get; set; }

    public int? DeepScan { get; set; }

    public bool? IsDownloadFile { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
