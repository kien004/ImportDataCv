using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class DispatchesHeader
{
    public int Id { get; set; }

    public string? DocumentCode { get; set; }

    public int DocumentNumber { get; set; }

    public string? DocumentSymbol { get; set; }

    public string? Origanization { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? PromulgateDate { get; set; }

    public string? Epitome { get; set; }

    public string? DocumentZone { get; set; }

    public string? DocumentType { get; set; }

    public string? SignUser { get; set; }

    public string? Position { get; set; }

    public string? Confidentiality { get; set; }

    public string? GetMothod { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedEditor { get; set; }

    public string? UnitEditor { get; set; }

    public bool? IsReply { get; set; }

    public bool? IsProcess { get; set; }

    public string? ReplyStatus { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public bool IsDeleted { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public DateTime? ExperiedReply { get; set; }

    public string? DispatchCode { get; set; }

    public string? ImportantLevel { get; set; }

    public string? SecurityLevel { get; set; }

    public bool? IsQppl { get; set; }

    public string? Type { get; set; }

    public string? DocumentSymbols { get; set; }

    public string? UserEditor { get; set; }

    public DateTime? SignDate { get; set; }

    public string? CreatedUserId { get; set; }

    public int? Year { get; set; }
}
