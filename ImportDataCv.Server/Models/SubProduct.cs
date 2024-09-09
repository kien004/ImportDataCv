using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SubProduct
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public string? AttributeCode { get; set; }

    public string? AttributeName { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }

    public string? Unit { get; set; }

    public string? Image { get; set; }

    public string? ProductQrCode { get; set; }

    public string? Group { get; set; }

    public string? Value { get; set; }

    public string? Type { get; set; }

    public decimal? InStock { get; set; }

    public decimal? ForecastInStock { get; set; }

    public DateTime? ForecastTime { get; set; }

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

    /// <summary>
    /// Giá /m...
    /// </summary>
    public decimal? PricePerM { get; set; }

    /// <summary>
    /// Giá / m2
    /// </summary>
    public decimal? PricePerM2 { get; set; }

    public string? ImpType { get; set; }
}
