using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class OtpManger
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Otp { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool IsDeleted { get; set; }
}
