using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FundLoadingSmsBank
{
    public int Id { get; set; }

    public string? AccSender { get; set; }

    public string? Sender { get; set; }

    public string? AccReceiver { get; set; }

    public string? Receiver { get; set; }

    public string? MoneyTranfer { get; set; }

    public string? Currency { get; set; }

    public DateTime? TranferTime { get; set; }

    public string? AccBalance { get; set; }

    public string? SmsRaw { get; set; }

    public string? SmsStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? CurrencyBalance { get; set; }

    public string? BankName { get; set; }
}
