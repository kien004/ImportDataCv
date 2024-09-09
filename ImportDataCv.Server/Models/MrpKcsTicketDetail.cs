using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MrpKcsTicketDetail
{
    public int Id { get; set; }

    public string? KcsCode { get; set; }

    public string? ProductCode { get; set; }

    public decimal? PressureValue { get; set; }

    public decimal? PurityValue { get; set; }

    public string? PressureUnit { get; set; }

    public string? PurityUnit { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
