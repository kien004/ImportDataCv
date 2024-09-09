using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductQualityInspectionImpDetail
{
    public int Id { get; set; }

    public string? QcTicketCode { get; set; }

    public string? ProdCodeLst { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateTime? CheckingDate { get; set; }

    public string? SupplierCode { get; set; }

    public string? DeliveryNo { get; set; }

    public string? FacilitySpect { get; set; }

    public string? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? Results { get; set; }

    public string? Content { get; set; }
}
