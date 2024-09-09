using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class TransDeliveryNoteDetail
{
    public int Id { get; set; }

    public string? DeliveryOrderNo { get; set; }

    public string? KindOfGoods { get; set; }

    public string? Description { get; set; }

    public decimal? Ton { get; set; }

    public decimal? Bags { get; set; }

    public string? LotNo { get; set; }

    public string? Remark { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
