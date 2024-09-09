using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class InvoiceCustomerGate
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? ServiceCode { get; set; }

    public string? TaxNumber { get; set; }

    public string? PassWord { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
