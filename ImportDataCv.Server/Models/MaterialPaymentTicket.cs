using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MaterialPaymentTicket
{
    public int PaymentTickitId { get; set; }

    public string? PayCode { get; set; }

    public string? PayTitle { get; set; }

    public string? PayNote { get; set; }

    public bool? PayType { get; set; }

    public string? PayObjType { get; set; }

    public string? PayObjId { get; set; }

    public decimal? MoneyTotal { get; set; }

    public string? Currency { get; set; }

    public string? PayOfWay { get; set; }

    public string? PayerId { get; set; }

    public string? ReceiperId { get; set; }

    public DateTime? PayTimeCnt { get; set; }

    public string? PayRemain { get; set; }

    public DateTime? PayNextTime { get; set; }

    public decimal? PayNextMoney { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
