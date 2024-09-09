using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CardMapping
{
    public int Id { get; set; }

    public string? CardCode { get; set; }

    public string? BoardCode { get; set; }

    public string? ListCode { get; set; }

    public string? ProjectCode { get; set; }

    public string? ContractCode { get; set; }

    public string? CustomerCode { get; set; }

    public string? SupplierCode { get; set; }

    public string? Relative { get; set; }

    public string? TeamCode { get; set; }

    public string? GroupUserCode { get; set; }

    public string? UserId { get; set; }

    public string? Responsibility { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
