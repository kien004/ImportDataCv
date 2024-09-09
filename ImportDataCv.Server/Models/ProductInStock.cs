using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductInStock
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public int? IdImpProduct { get; set; }

    public int? ParentId { get; set; }

    public string? ProductNo { get; set; }

    public string? GattrCode { get; set; }

    public string? Image { get; set; }

    public string? StoreCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Weight { get; set; }

    public string? Unit { get; set; }

    public decimal? QuantityTemp { get; set; }

    public decimal? WeightTemp { get; set; }

    public string? ProductNoTemp { get; set; }

    public string? LotProductCode { get; set; }

    public string? ProductQrCode { get; set; }

    public string? ProductType { get; set; }

    public bool? MarkWholeProduct { get; set; }

    public string? PackCode { get; set; }

    public string? ProdCustomJson { get; set; }

    public bool? IsCustomized { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletionToken { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ProductImportDetail? IdImpProductNavigation { get; set; }

    public virtual ProductImportDetail? Parent { get; set; }
}
