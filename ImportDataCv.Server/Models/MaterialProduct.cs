using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MaterialProduct
{
    public int Id { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? GroupCode { get; set; }

    public string? Note { get; set; }

    public int? Accessory { get; set; }

    public string? Status { get; set; }

    public int? Flag { get; set; }

    public string? Barcode { get; set; }

    public string? Image { get; set; }

    public string? TypeCode { get; set; }

    public string? Unit { get; set; }

    public string? QrCode { get; set; }

    public string? Material { get; set; }

    public string? Pattern { get; set; }

    public string? Inheritance { get; set; }

    public string? Description { get; set; }

    public decimal? InStock { get; set; }

    public decimal? ForecastInStock { get; set; }

    public DateTime? ForecastTime { get; set; }

    public decimal? PricePerM { get; set; }

    public decimal? PricePerM2 { get; set; }

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

    public string? Label { get; set; }

    public decimal? Wide { get; set; }

    public decimal? High { get; set; }

    public string? ImpType { get; set; }

    public string? TypeCode2 { get; set; }

    public string? Packing { get; set; }

    public decimal? Weight { get; set; }

    public string? UnitWeight { get; set; }

    public string? Json { get; set; }

    public decimal? Long { get; set; }

    public string? Supplier { get; set; }

    public string? Brand { get; set; }

    public string? Serial { get; set; }

    public string? JsonStatus { get; set; }

    public string? LocationTxt { get; set; }

    public string? LocationGps { get; set; }

    public string? IndustryClass { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletionToken { get; set; }
}
