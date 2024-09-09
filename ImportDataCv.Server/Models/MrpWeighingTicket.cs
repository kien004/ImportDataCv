using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpWeighingTicket
{
    public int Id { get; set; }

    public string? WeighCode { get; set; }

    public string? WeighTitle { get; set; }

    public string? PlateCar { get; set; }

    public string? Item { get; set; }

    public string? Tec { get; set; }

    public string? CustomerCode { get; set; }

    public decimal? MassGross { get; set; }

    public DateTime? DateGross { get; set; }

    public decimal? MassNet { get; set; }

    public DateTime? DateNet { get; set; }

    public decimal? MassGood { get; set; }

    public string? Unit { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
