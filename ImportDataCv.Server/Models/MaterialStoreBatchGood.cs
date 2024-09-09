using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MaterialStoreBatchGood
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? DateReiceive { get; set; }

    public DateTime? DateProduce { get; set; }

    public DateTime? DateExpire { get; set; }

    public int? Quantity { get; set; }

    public int? SupplierId { get; set; }

    public string? Unit { get; set; }

    public int? StoreId { get; set; }

    public string? Barcode { get; set; }

    public string? ProductCode { get; set; }

    public string? BlockCode { get; set; }

    public string? Madein { get; set; }

    public string? Description { get; set; }

    public string? Packing { get; set; }

    public double? Cost { get; set; }

    public int? Sale { get; set; }

    public string? Currency { get; set; }

    public int? Vat { get; set; }

    public double? Total { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
