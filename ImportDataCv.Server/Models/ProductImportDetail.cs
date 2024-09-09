using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductImportDetail
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string? TicketCode { get; set; }

    public string? ProductCode { get; set; }

    public string? GattrCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? ProductNo { get; set; }

    public string? Unit { get; set; }

    public decimal? SalePrice { get; set; }

    public string? Currency { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? TaxRate { get; set; }

    public int? Discount { get; set; }

    public int? Commission { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletionToken { get; set; }

    public string? ProductQrCode { get; set; }

    public string? LotProductCode { get; set; }

    public string? RackCode { get; set; }

    public string? ProductType { get; set; }

    public decimal? QuantityIsSet { get; set; }

    public string? PackType { get; set; }

    public string? ProductLot { get; set; }

    public string? CusCode { get; set; }

    public string? PoSupCode { get; set; }

    public string? Section { get; set; }

    public int? QuantityImp { get; set; }

    public bool? IsIntact { get; set; }

    public bool? MarkWholeProduct { get; set; }

    public string? PackCode { get; set; }

    public string? PackLot { get; set; }

    public string? ProdCustomJson { get; set; }

    public bool? IsCustomized { get; set; }

    public string? ImpType { get; set; }

    public string? Status { get; set; }

    public decimal? Weight { get; set; }

    public virtual ICollection<ProductImpGattr> ProductImpGattrs { get; set; } = new List<ProductImpGattr>();

    public virtual ICollection<ProductImpParent> ProductImpParents { get; set; } = new List<ProductImpParent>();

    public virtual ICollection<ProductInStock> ProductInStockIdImpProductNavigations { get; set; } = new List<ProductInStock>();

    public virtual ICollection<ProductInStock> ProductInStockParents { get; set; } = new List<ProductInStock>();
}
