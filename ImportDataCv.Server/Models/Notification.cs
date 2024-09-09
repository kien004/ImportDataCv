using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Notification
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int NotifyId { get; set; }

    public string? NotifyCode { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public DateTime? DateEvent { get; set; }

    public DateTime? DateWarning { get; set; }

    public bool? IsWarning { get; set; }

    public string? LstContractCode { get; set; }

    public string? Receiver { get; set; }

    public string? ReceiverConfirm { get; set; }

    public DateTime? ConfirmTime { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
