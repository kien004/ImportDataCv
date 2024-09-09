using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class OrderSupplierReviewDetail
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string SupplierCode { get; set; } = null!;

    public string? QcSystem { get; set; }

    public string? Pricing { get; set; }

    public string? Unit { get; set; }

    public string? PaymentMethod { get; set; }

    public string? DeliveryTime { get; set; }

    public string ReviewCode { get; set; } = null!;

    public string? Reputation { get; set; }

    public string? ResultReview { get; set; }

    public string? Noted { get; set; }
}
