using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmRomoocRemooc
{
    public int Id { get; set; }

    public string? Barcode { get; set; }

    public string? Code { get; set; }

    public DateTime? DateOfEntry { get; set; }

    public DateTime? DateOfUse { get; set; }

    public int? Extrafield { get; set; }

    public int? FlagDelete { get; set; }

    public string? Generic { get; set; }

    public string? Image { get; set; }

    public string? Origin { get; set; }

    public string? Title { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? CompanyCode { get; set; }

    public int? CreateBy { get; set; }

    public int? UpdateBy { get; set; }

    public string? Container { get; set; }

    public string? Type { get; set; }

    public int? NumberTruck { get; set; }

    public string? OwerCode { get; set; }

    public string? Brand { get; set; }

    public string? SelfWeight { get; set; }

    public string? DesignWeight { get; set; }

    public string? TotalWeight { get; set; }

    public string? Number { get; set; }

    public string? Size { get; set; }

    public string? CurentSize { get; set; }

    public DateTime? DayRegistry { get; set; }

    public string? Description { get; set; }

    public string? InternalCode { get; set; }

    public string? LisencePlate { get; set; }

    public string? PositionGps { get; set; }

    public string? PositionText { get; set; }

    public int? SumDistance { get; set; }

    public string? Group { get; set; }

    public string? Note { get; set; }
}
