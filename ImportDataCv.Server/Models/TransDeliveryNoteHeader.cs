using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class TransDeliveryNoteHeader
{
    public int Id { get; set; }

    public string? LnNo { get; set; }

    public string? DnNo { get; set; }

    public DateTime? Date { get; set; }

    public string? Consignee { get; set; }

    public string? Means { get; set; }

    public string? IdNo { get; set; }

    public string? EnterCardNo { get; set; }

    public string? CarrierName { get; set; }

    public string? LoadingPlace { get; set; }

    public string? UnloadingPlace { get; set; }

    public DateTime? TimeIn { get; set; }

    public DateTime? TimeOut { get; set; }

    public float? Hour { get; set; }

    public string? Reason { get; set; }

    public string? Note { get; set; }

    public string? PreparedBySign { get; set; }

    public string? CarrierSign { get; set; }

    public string? ConsigneeSign { get; set; }

    public string? SecuritySign { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
