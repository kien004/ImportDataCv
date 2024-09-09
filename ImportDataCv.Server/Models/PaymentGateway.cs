using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PaymentGateway
{
    public int Id { get; set; }

    public string? ServiceType { get; set; }

    public string? Logo { get; set; }

    public string? GatewayCode { get; set; }

    public string? GatewayName { get; set; }

    public string? Email { get; set; }

    public string? ConfigJson { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }
}
