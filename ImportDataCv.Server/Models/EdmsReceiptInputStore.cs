using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsReceiptInputStore
{
    public int Id { get; set; }

    public string? RcTicketCode { get; set; }

    public string? BrCode { get; set; }

    public string? WhsCode { get; set; }

    public string? WhsUser { get; set; }

    public string? NumBox { get; set; }

    public string? DocType { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Note { get; set; }

    public string? RcSupport { get; set; }

    public string? RcStatus { get; set; }

    public string? QrCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? RqId { get; set; }

    public string? PersonSender { get; set; }
}
