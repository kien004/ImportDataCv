using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class OrderSupplierReview
{
    public int Id { get; set; }

    public string? ReviewCode { get; set; }

    public string? TitleReview { get; set; }

    public string? CreatorTicket { get; set; }

    public string? DateReviewTicket { get; set; }

    public string? Status { get; set; }

    public string? Noted { get; set; }

    public string? SupplierResultReview { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Flag { get; set; }
}
