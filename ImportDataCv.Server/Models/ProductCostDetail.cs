using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProductCostDetail
{
    public int Id { get; set; }

    public string? HeaderCode { get; set; }

    public string? ProductCode { get; set; }

    public decimal? PriceRetail { get; set; }

    public int? Tax { get; set; }

    public decimal? Commission { get; set; }

    public decimal? Discount { get; set; }

    public decimal? CustomFee { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public decimal? PriceCost { get; set; }

    /// <summary>
    /// Giá đại lý catalogue
    /// </summary>
    public decimal? PriceCostCatelogue { get; set; }

    /// <summary>
    /// Giá đại lý đường bay
    /// </summary>
    public decimal? PriceCostAirline { get; set; }

    /// <summary>
    /// Giá đại lý đường biển
    /// </summary>
    public decimal? PriceCostSea { get; set; }

    /// <summary>
    /// Giá bán lẻ có thi công
    /// </summary>
    public decimal? PriceRetailBuild { get; set; }

    /// <summary>
    /// Giá bán lẻ có thi công bay
    /// </summary>
    public decimal? PriceRetailBuildAirline { get; set; }

    /// <summary>
    /// Giá bán lẻ có thi công kho,biển
    /// </summary>
    public decimal? PriceRetailBuildSea { get; set; }

    /// <summary>
    /// Giá bán lẻ không thi công
    /// </summary>
    public decimal? PriceRetailNoBuild { get; set; }

    /// <summary>
    /// Giá bán lẻ không thi công bay
    /// </summary>
    public decimal? PriceRetailNoBuildAirline { get; set; }

    /// <summary>
    /// Giá bán lẻ không thi công kho, biển
    /// </summary>
    public decimal? PriceRetailNoBuildSea { get; set; }

    public string? Catelogue { get; set; }

    public decimal? PriceCostDefault { get; set; }
}
