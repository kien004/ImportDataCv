using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CompanyBankAccount
{
    public int Id { get; set; }

    public string? BankId { get; set; }

    public string? BankName { get; set; }

    public string? BankAccount { get; set; }

    public string? BankOwner { get; set; }

    public string? BankImage { get; set; }

    public string? BankDeeplink { get; set; }

    public string? BankCode { get; set; }

    public bool? IsActive { get; set; }

    public int? Order { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
