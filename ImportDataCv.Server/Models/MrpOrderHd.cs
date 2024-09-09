using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpOrderHd
{
    public int Id { get; set; }

    public string? OrderCode { get; set; }

    public string? Title { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerTitle { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public DateTime? DateOrdered { get; set; }

    public DateTime? DateReceived { get; set; }

    public string? AddressDelivery { get; set; }

    public string? Contact { get; set; }

    public string? Contacter { get; set; }

    public string? CreatedBy { get; set; }

    public string? LogStatus { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Payment { get; set; }
}
